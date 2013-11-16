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

        public ClP_StartUp(I_StartUpConfiguration vrpView) : base(vrpView)
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

            View.Server = new Server(View.CurrentServerName);

            View.Server.ConnectionContext.ConnectTimeout = 2;
            View.ServerStatus = View.Server.Status.ToString();

            LoadDatabases();
        }

        private void LoadDatabases()
        {
            var server = new Server(View.CurrentServerName);

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

        public void LoadSln()
        {
            System.Configuration.Configuration confisg = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            if (!confisg.AppSettings.Settings.AllKeys.Contains("SlnPth"))
            {
                View.SlnPth = string.Empty;
            }
            else
            {
                View.SlnPth = confisg.AppSettings.Settings["SlnPth"].Value;
            }
        }

        private void SaveLastDatabase()
        {
            vrcConfig.ServerName = View.CurrentServerName;
            vrcConfig.Database = View.CurrentDatabaseName;

            vrcConfig.SaveConfig();
        }

        private void SaveLastSolution()
        {
            System.Configuration.Configuration confisg = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            if (!confisg.AppSettings.Settings.AllKeys.Contains("SlnPth"))
            {
                confisg.AppSettings.Settings.Add("SlnPth", View.SlnPth);
            }
            else
            {
                confisg.AppSettings.Settings["SlnPth"].Value = View.SlnPth;
            }

            confisg.Save(ConfigurationSaveMode.Minimal);
        }

        public void SaveToConfig()
        {
            if (!View.IsLoading)
            {
                SaveLastDatabase();
                SaveLastSolution();
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
                    Cl_Messages.Messages.Error("Nie mo¿na po³¹czyæ siê z serwerem.");
                }
            });

            vrlLoader.Execute("£¹czenie z serwerem");
        }
    }
}