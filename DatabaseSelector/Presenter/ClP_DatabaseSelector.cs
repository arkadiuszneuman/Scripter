using DatabaseSelector.Interface;
using DatabaseSelector.Utilities;
using inSolutions.Controls.Loader.Utilities;
using inSolutions.Utilities;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSelector.Presenter
{
    public class ClP_DatabaseSelector
    {
        private Cl_Config vrcConfig;
        private readonly I_DatabaseSelector vrcView;

        public ClP_DatabaseSelector(I_DatabaseSelector vrpView)
        {
            vrcView = vrpView;
        }

        public I_DatabaseSelector View
        {
            get
            {
                return vrcView as I_DatabaseSelector;
            }
        }

        public void ConnectToServer()
        {
            var vrlServer = new Server(GetServerConnection());
            vrlServer.ConnectionContext.ConnectTimeout = 2;
            
            LoadDatabases(vrlServer);
        }

        public ServerConnection GetServerConnection()
        {
            ServerConnection serverConnection;
            if (View.IsSQLAuthentication)
            {
                serverConnection = new ServerConnection(View.CurrentServerName, View.Login, View.Pass);
            }
            else
            {
                serverConnection = new ServerConnection(View.CurrentServerName);
            }

            serverConnection.ConnectTimeout = 20;
            return serverConnection;
        }

        private void LoadDatabases(Server vrpServer)
        {
            Database[] databases = new Database[vrpServer.Databases.Count];
            vrpServer.Databases.CopyTo(databases, 0);
            View.DatabaseList = databases.Where(d => !d.IsSystemObject && !d.Name.ToLower().Contains("reportserver")).Select(d => d.Name);
        }

        private void LoadLastDatabase()
        {
            vrcConfig = Cl_Config.LoadConfig();

            if (!string.IsNullOrEmpty(vrcConfig.ServerName))
            {
                View.CurrentServerName = vrcConfig.ServerName;
                View.IsSQLAuthentication = vrcConfig.IsSQLAuthentication;
                View.Login = vrcConfig.Login;
                View.Pass = vrcConfig.Pass;

                ConnectToServer();

                if (View.DatabaseList.Contains(vrcConfig.Database))
                {
                    View.CurrentDatabaseName = vrcConfig.Database;
                }
            }
        }

        private void SaveLastDatabase()
        {
            vrcConfig.ServerName = View.CurrentServerName;
            vrcConfig.Database = View.CurrentDatabaseName;
            vrcConfig.IsSQLAuthentication = View.IsSQLAuthentication;
            vrcConfig.Login = View.Login;
            vrcConfig.Pass = View.Pass;

            vrcConfig.SaveConfig();
        }

        public void SaveToConfig()
        {
            SaveLastDatabase();
        }

        #region Overrides of ClP_BaseForm

        public void LoadDataSources()
        {
            LoadLastDatabase();
        }

        #endregion

        public void Connect()
        {
            var vrlLoader = new Cl_Loader(new Cl_ProgramMessages(new Cl_ProgramName()), (l) =>
            {
                try
                {
                    if (!string.IsNullOrEmpty(View.CurrentServerName))
                    {
                        ConnectToServer();
                    }
                }
                catch (ConnectionFailureException)
                {
                    new Cl_ProgramMessages(new Cl_ProgramName()).Error("Nie można połączyć się z serwerem.");
                }
            });

            vrlLoader.Execute("Łączenie z serwerem");
        }
    }
}
