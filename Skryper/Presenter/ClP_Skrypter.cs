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

namespace Skryper.Presenter
{
    public class ClP_Skrypter : inSolutions.Controls.BaseForms.Presenter.ClP_EntityBaseForm
    {

        private new readonly I_AdditlionalOptions vrcView;

        public ClP_Skrypter(object vrpView, I_ConfigDb vrpConfigData)
            : base((I_Scripter)vrpView)
        {
            ConfigData = vrpConfigData;
            vrcView = (I_AdditlionalOptions)vrpView;
        }


        public override void LoadDataSources()
        {
            LoadDatabaseVersionDatasource();
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

        private void LoadDatabaseVersionDatasource()
        {
            vrcView.DatabaseVersion = Enumeration.GetAll<E_ServerVersion>();
        }

        public I_Scripter View
        {
            get
            {
                return vrcView as I_Scripter;
            }
        }

        private void AssignLoadedObjectsToViews(IEnumerable<Cl_DatabaseObject> vrpLoadedObjects)
        {
            var databaseObjects = vrpLoadedObjects as Cl_DatabaseObject[] ?? vrpLoadedObjects.ToArray();

            View.Tables = databaseObjects.Where(o => o.Type == E_SmoObjectType.Table);
            View.Procedures = databaseObjects.Where(o => o.Type == E_SmoObjectType.StoredProcedure);
            View.Functions = databaseObjects.Where(o => o.Type == E_SmoObjectType.Function);
            View.Views = databaseObjects.Where(o => o.Type == E_SmoObjectType.View);
            View.Triggers = databaseObjects.Where(o => o.Type == E_SmoObjectType.Trigger);
            View.Data = databaseObjects.Where(o => o.Type == E_SmoObjectType.Data);
        }

        private void InitLoadedObjects(IEnumerable<Cl_DatabaseObject> vrpLoadedObjects)
        {
            var server = new Server(ConfigData.CurrentServerName);
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
                            vrlObject.SmoObject = null;
                            break;
                        //Dane są pobierane z tabeli
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
                        .Union(View.Data);
        }

        private void CheckSelectedObjects(IEnumerable<Cl_DatabaseObject> objects)
        {
            if (objects.Any(o => o.SmoObject == null))
            {
                throw new InvalidOperationException("Dodane są obiekty, które nie istnieją w bazie danych.");
            }
        }

        public void GenerateAndSaveScript()
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
            scriptFilesManager.SaveObjectsToConfig(vrlContainer);

            foreach (var vrlGroupped in allObjects.GroupBy(o => o.FileName))
            {
                Cl_ScriptGen gen = new Cl_ScriptGen(ConfigData.CurrentServerName, ConfigData.CurrentDatabaseName, vrcView);
                string generatedSql = gen.Generate(vrlGroupped, View as I_ScriptProgress);
                View.GeneratedSql = generatedSql;

                scriptFilesManager.SaveScript(generatedSql, vrlGroupped.Key.Trim());
            }
        }

        private I_ConfigDb ConfigData { get; set; }
    }
}
