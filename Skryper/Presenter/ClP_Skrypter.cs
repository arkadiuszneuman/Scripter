using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Interface;
using Skryper.Utilities;
using Skryper.Utilities.ScriptGen;
using Skryper.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Encrypter;

namespace Skryper.Presenter
{
    public class ClP_Skrypter : inSolutions.Controls.BaseForms.Presenter.ClP_EntityBaseForm
    {
        public ClP_Skrypter(I_Scripter vrpView, I_ConfigDb vrpConfigData)
            : base(vrpView)
        {
            ConfigData = vrpConfigData;
        }


        public override void LoadDataSources()
        {
            View.StoredProceduresFileName = View.TablesFileName = View.TriggersFileName = View.ViewsFileName = View.FunctionsFileName = "Structure.sql";
            LoadObjects();
        }

        private void LoadObjects()
        {
            var scriptFilesManager = new Cl_ScripterFilesManager(ConfigData.SlnPth);
            var vrlContainer = scriptFilesManager.LoadObjectsFromConfig();

            if (vrlContainer != null)
            {
                var databaseObjects = vrlContainer.DatabaseObjects.ToArray();

                InitLoadedObjects(databaseObjects);
                AssignLoadedObjectsToViews(databaseObjects);
                AssignDefaultNames(vrlContainer);
            }
        }

        private void AssignDefaultNames(Cl_ScriptFilesContainer vrlContainer)
        {
            View.StoredProceduresFileName = vrlContainer.StoredProceduresFileName;
            View.TablesFileName = vrlContainer.TablesFileName;
            View.FunctionsFileName = vrlContainer.FunctionsFileName;
            View.ViewsFileName = vrlContainer.ViewsFileName;
            View.TriggersFileName = vrlContainer.TriggersFileName;
        }

        public I_Scripter View
        {
            get
            {
                return vrcView as I_Scripter;
            }
        }

        private ServerConnection GetConnection()
        {
            ServerConnection serverConnection;
            if (ConfigData.IsSQLAuthentication)
            {
                serverConnection = new ServerConnection(ConfigData.CurrentServerName, ConfigData.Login, ConfigData.Pass);
            }
            else
            {
                serverConnection = new ServerConnection(ConfigData.CurrentServerName);
            }

            return serverConnection;
        }

        private void AssignLoadedObjectsToViews(IEnumerable<Cl_DatabaseObject> vrpLoadedObjects)
        {
            var databaseObjects = vrpLoadedObjects as Cl_DatabaseObject[] ?? vrpLoadedObjects.ToArray();

            View.Tables = databaseObjects.Where(o => o.Type == E_SmoObjectType.Table);
            View.Procedures = databaseObjects.Where(o => o.Type == E_SmoObjectType.StoredProcedure);
            View.Functions = databaseObjects.Where(o => o.Type == E_SmoObjectType.Function);
            View.Views = databaseObjects.Where(o => o.Type == E_SmoObjectType.View);
            View.Triggers = databaseObjects.Where(o => o.Type == E_SmoObjectType.Trigger);
        }

        private void InitLoadedObjects(IEnumerable<Cl_DatabaseObject> vrpLoadedObjects)
        {
            var server = new Server(GetConnection());
            var database = server.Databases[ConfigData.CurrentDatabaseName];

            foreach (var vrlGrouppedObjects in vrpLoadedObjects.GroupBy(o => o.Type))
            {
                foreach (var vrlObject in vrlGrouppedObjects)
                {
                    switch (vrlGrouppedObjects.Key)
                    {
                        case E_SmoObjectType.Table:
                            vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            break;
                        case E_SmoObjectType.StoredProcedure:
                            vrlObject.SmoObject = database.StoredProcedures[vrlObject.Name];
                            break;
                        case E_SmoObjectType.Function:
                            vrlObject.SmoObject = database.UserDefinedFunctions[vrlObject.Name];
                            break;
                        case E_SmoObjectType.View:
                            vrlObject.SmoObject = database.Views[vrlObject.Name];
                            break;
                        case E_SmoObjectType.Trigger:
                            vrlObject.SmoObject = database.Tables.Cast<Table>().SelectMany(o => o.Triggers.Cast<Trigger>()).SingleOrDefault(o => o.Name == vrlObject.Name);
                            break;
                        case E_SmoObjectType.Data:
                            vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }
        }

        private IEnumerable<Cl_DatabaseObject> GetAllObjects()
        {
            return View.Tables
                        .Union(View.Procedures)
                        .Union(View.Functions)
                        .Union(View.Views)
                        .Union(View.Triggers)
                        ;
        }

        private void CheckSelectedObjects(IEnumerable<Cl_DatabaseObject> objects)
        {
            if (objects.Any(o => o.SmoObject == null))
            {
                throw new InvalidOperationException("Dodane są obiekty, które nie istnieją w bazie danych.");
            }
        }

        public void GenerateAndSaveScript(Cl_Loader loader)
        {
            var allObjects = GetAllObjects();
            CheckSelectedObjects(allObjects);

            Cl_ScriptFilesContainer vrlContainer = new Cl_ScriptFilesContainer()
            {
                DatabaseObjects = allObjects.ToList(),
                FunctionsFileName = View.FunctionsFileName,
                StoredProceduresFileName = View.StoredProceduresFileName,
                TablesFileName = View.TablesFileName,
                TriggersFileName = View.TriggersFileName,
                ViewsFileName = View.ViewsFileName
            };

            Cl_ScripterFilesManager scriptFilesManager = new Cl_ScripterFilesManager(ConfigData.SlnPth);
            if (View.CheckoutTFS)
            {
                scriptFilesManager.TFSAddOrCheckoutFile(scriptFilesManager.GetConfigFilePath());
            }
            scriptFilesManager.SaveObjectsToConfig(vrlContainer);
            
            foreach (var vrlGroupped in allObjects.GroupBy(o => o.FileName))
            {
                loader.SetText(String.Format("Generowanie skryptu dla pliku: {0}...", vrlGroupped.Key));

                Cl_ScriptGen gen;
                if (ConfigData.IsSQLAuthentication)
                {
                    gen = new Cl_ScriptGen(ConfigData.CurrentServerName, ConfigData.CurrentDatabaseName,ConfigData.Login, ConfigData.Pass);
                }
                else
                {
                    gen = new Cl_ScriptGen(ConfigData.CurrentServerName, ConfigData.CurrentDatabaseName);
                }
                string generatedSql = gen.Generate(vrlGroupped, View as I_ScriptProgress);
                View.GeneratedSql = generatedSql;

                if (View.CheckoutTFS)
                {
                    scriptFilesManager.TFSAddOrCheckoutFile(scriptFilesManager.GetFullFilePath(vrlGroupped.Key));
                }
                scriptFilesManager.SaveScript(generatedSql, vrlGroupped.Key.Trim());
                if (View.CheckoutTFS)
                {
                    scriptFilesManager.TFSAddOrCheckoutFile(scriptFilesManager.GetEncryptedFilePath(vrlGroupped.Key));
                }
                scriptFilesManager.SaveEncryptedFile(vrlGroupped.Key);
                
            }
        }

        

        private I_ConfigDb ConfigData { get; set; }
    }
}
