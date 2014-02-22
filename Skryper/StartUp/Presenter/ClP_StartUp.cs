using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Interface;
using Skryper.StartUp.Interface;
using Skryper.Utilities;
using Skryper.Utilities.ScriptGen;
using Skryper.View;
using inSolutions.Controls.Loader.Utilities;
using Configuration = Microsoft.SqlServer.Management.Smo.Configuration;

namespace Skryper.StartUp.Presenter
{
    public class ClP_StartUp : inSolutions.Controls.BaseForms.Presenter.ClP_EntityBaseForm
    {
        private Cl_Config vrcConfig;

        public ClP_StartUp(I_StartUpConfiguration vrpView)
            : base(vrpView)
        {

        }

        public I_StartUpConfiguration View
        {
            get
            {
                return vrcView as I_StartUpConfiguration;
            }
        }

        public void ConnectToServer()
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

            View.Server = new Server(serverConnection);

            View.Server.ConnectionContext.ConnectTimeout = 2;

            LoadDatabases(serverConnection);
        }

        private void LoadDatabases(ServerConnection vrpConnection)
        {
            var server = new Server(vrpConnection);

            Database[] databases = new Database[server.Databases.Count];
            server.Databases.CopyTo(databases, 0);
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
                View.SlnPth = vrcConfig.SlnPath;

                ConnectToServer();

                if (View.DatabaseList.Contains(vrcConfig.Database))
                {
                    View.CurrentDatabaseName = vrcConfig.Database;
                }
            }
        }

        public void ChooseSln()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Plik solucji (*.sln)|*.sln";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.View.SlnPth = openFileDialog.FileName;
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
            vrcConfig.SlnPath = View.SlnPth;

            vrcConfig.SaveConfig();
        }

        public void SaveToConfig()
        {
            if (!View.IsLoading)
            {
                SaveLastDatabase();
            }
        }

        #region Overrides of ClP_BaseForm

        public override void LoadDataSources()
        {
            LoadLastDatabase();
        }

        #endregion

        public void ShowMain()
        {
            using (var vrfScrypter = new Frm_Skrypter(View))
            {
                vrfScrypter.ShowDialog();
            }
        }

        public void Connect()
        {
            var vrlLoader = new Cl_Loader(Cl_Messages.Messages, (l) =>
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
                    Cl_Messages.Messages.Error("Nie mo�na po��czy� si� z serwerem.");
                }
            });

            vrlLoader.Execute("��czenie z serwerem");
        }
    }
}