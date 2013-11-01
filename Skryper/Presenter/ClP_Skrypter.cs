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
        private Cl_Config config;

        public ClP_Skrypter(I_Scripter vrpView)
            : base(vrpView)
        {
        }

        public void ConnectToServer()
        {

            View.Server = new Server(View.ServerName);

            View.Server.ConnectionContext.ConnectTimeout = 2;
            View.ServerStatus = View.Server.Status.ToString();

            LoadDatabases();
        }

        public override void LoadDataSources()
        {
            LoadLastDatabase();
        }

        private void LoadLastDatabase()
        {
            config = Cl_Config.LoadConfig();

            if (!string.IsNullOrEmpty(config.ServerName))
            {
                View.ServerName = config.ServerName;
                ConnectToServer();
                if (View.DatabaseList.Contains(config.Database))
                {
                    View.SelectedDatabase = config.Database;
                }
            }
        }

        private void SaveLastDatabase()
        {
            config.ServerName = View.ServerName;
            config.Database = View.SelectedDatabase;

            config.SaveConfig();
        }

        private void LoadDatabases()
        {
            var server = new Server(View.ServerName);

            Database[] databases = new Database[server.Databases.Count];
            server.Databases.CopyTo(databases, 0);
            View.DatabaseList = databases.Where(d => !d.IsSystemObject && !d.Name.ToLower().Contains("reportserver")).Select(d => d.Name);
        }

        public I_Scripter View
        {
            get
            {
                return vrcView as I_Scripter;
            }
        }

        public void DatabaseChanged()
        {
            if (!View.IsLoading)
            {
                SaveLastDatabase();
            }
        }

        public void ChooseSln()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Plik solucji (*.sln)|*.sln";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.View.SlnPath = openFileDialog.FileName;

                    Cl_ScripterFilesManager scriptFilesManager = new Cl_ScripterFilesManager(this.View.SlnPath);
                    IEnumerable<Cl_DatabaseObject> loadedObjects = scriptFilesManager.LoadObjectsFromConfig();
                    InitLoadedObjects(loadedObjects);
                    AssignLoadedObjectsToViews(loadedObjects);
                }
            }
        }

        private void AssignLoadedObjectsToViews(IEnumerable<Cl_DatabaseObject> loadedObjects)
        {
            View.Tables = loadedObjects.Where(o => o.Type == E_SmoObjectType.Table);
            View.Procedures = loadedObjects.Where(o => o.Type == E_SmoObjectType.StoredProcedure);
            View.Functions = loadedObjects.Where(o => o.Type == E_SmoObjectType.Function);
            View.Views = loadedObjects.Where(o => o.Type == E_SmoObjectType.View);
            View.Triggers = loadedObjects.Where(o => o.Type == E_SmoObjectType.Trigger);
        }

        private void InitLoadedObjects(IEnumerable<Cl_DatabaseObject> loadedObjects)
        {
            var server = new Server(View.ServerName);
            var database = server.Databases[View.SelectedDatabase];

            foreach (var vrlGrouppedObjects in loadedObjects.GroupBy(o => o.Type))
            {
                foreach (var vrlObject in vrlGrouppedObjects)
                {
                    switch (vrlGrouppedObjects.Key)
                    {
                        case E_SmoObjectType.Table:
                            if (database.Tables.Contains(vrlObject.Name))
                            {
                                vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            }
                            break;
                        case E_SmoObjectType.StoredProcedure:
                            if (database.StoredProcedures.Contains(vrlObject.Name))
                            {
                                vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            }
                            break;
                        case E_SmoObjectType.Function:
                            if (database.UserDefinedFunctions.Contains(vrlObject.Name))
                            {
                                vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            }
                            break;
                        case E_SmoObjectType.View:
                            if (database.Views.Contains(vrlObject.Name))
                            {
                                vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            }
                            break;
                        case E_SmoObjectType.Trigger:
                            if (database.Triggers.Contains(vrlObject.Name))
                            {
                                vrlObject.SmoObject = database.Tables[vrlObject.Name];
                            }
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }
        }
    }
}
