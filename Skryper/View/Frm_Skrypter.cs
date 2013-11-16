using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Presenter;
using Skryper.Interface;
using System.Collections.Generic;
using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Common;
using Skryper.Utilities;
using Skryper.Utilities.ScriptGen;
using System.Linq;

namespace Skryper.View
{
    public partial class Frm_Skrypter : inSolutions.Controls.BaseForms.View.Frm_EntityBaseForm, I_Scripter, I_ScriptProgress,I_AdditlionalOptions
    {
        #region Constructor

        public Frm_Skrypter()
        {
            InitializeComponent();
            vrcPresenter = new ClP_Skrypter(this);
        }

        #endregion

        #region Events

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cl_Loader vrlLoader = new Cl_Loader(Cl_Messages.Messages, (l) =>
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(frtxtServerName.Text))
                        {
                            Presenter.ConnectToServer();
                        }
                    }
                    catch (ConnectionFailureException)
                    {
                        Cl_Messages.Messages.Error("Nie można połączyć się z serwerem.");
                    }
                });


            vrlLoader.Execute("Łączenie z serwerem");

        }

        #endregion

        #region Public properties
        public Server Server { get; set; }

        public string ServerName
        {
            get
            {
                return this.frtxtServerName.Text;
            }
            set
            {
                this.frtxtServerName.Text = value;
            }
        }

        public string ServerStatus
        {
            set
            {
                this.frtxtStatus.Text = value;
            }

        }


        public new ClP_Skrypter Presenter
        {
            get
            {
                return this.vrcPresenter as ClP_Skrypter;
            }
        }
        #endregion

        public IEnumerable<string> DatabaseList
        {
            get
            {
                return this.frtxtDatabase.Properties.DataSource as IEnumerable<string>;
            }
            set
            {
                Action vrlAction = () => this.frtxtDatabase.Properties.DataSource = value;
                if (this.frtxtDatabase.InvokeRequired)
                {
                    this.frtxtDatabase.Invoke(new MethodInvoker(vrlAction));
                }
                else
                {
                    vrlAction();
                }
            }
        }

        private void frtxtDatabase_EditValueChanged(object sender, EventArgs e)
        {
            Presenter.DatabaseChanged();

            vruTables.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
            vruProcedures.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
            vruFunctions.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
            vruViews.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
            vruTriggers.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
        }


        public string SelectedDatabase
        {
            get
            {
                return Convert.ToString(this.frtxtDatabase.EditValue);
            }
            set
            {
                this.frtxtDatabase.EditValue = value;
            }
        }

        private Cl_Loader vrcLoader;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            vrcLoader = new Cl_Loader(l =>
                {
                    Presenter.GenerateAndSaveScript();
                });

            try
            {
                vrcLoader.Execute("Generowanie skryptu...");
            }
            catch (Exception ex)
            {
                Cl_Messages.Messages.Warning(ex.Message);
            }
        }

        public void CreateProgress(int min, int max)
        {
            vrcLoader.CreateProgress(min, max);
        }

        public void ReportProgress(int vrpProgress)
        {
            vrcLoader.ReportProgress(vrpProgress);
        }

        private void btnChooseSln_Click(object sender, EventArgs e)
        {
            Presenter.ChooseSln();
        }

        public string SlnPath
        {
            get
            {
                return this.frtxtSlnPath.Text;
            }
            set
            {
                this.frtxtSlnPath.Text = value;
            }
        }

        public IEnumerable<Cl_DatabaseObject> Tables
        {
            get { return this.vruTables.DataSource; }
            set { this.vruTables.DataSource = value.ToList(); }
        }

        public IEnumerable<Cl_DatabaseObject> Procedures
        {
            get { return this.vruProcedures.DataSource; }
            set { this.vruProcedures.DataSource = value.ToList(); }
        }

        public IEnumerable<Cl_DatabaseObject> Functions
        {
            get { return this.vruFunctions.DataSource; }
            set { this.vruFunctions.DataSource = value.ToList(); }
        }

        public IEnumerable<Cl_DatabaseObject> Views
        {
            get { return this.vruViews.DataSource; }
            set { this.vruViews.DataSource = value.ToList(); }
        }

        public IEnumerable<Cl_DatabaseObject> Triggers
        {
            get { return this.vruTriggers.DataSource; }
            set { this.vruTriggers.DataSource = value.ToList(); }
        }


        public string GeneratedSql
        {
            set 
            {
                Action vrlAction = () => this.frtxtGeneratedScript.Text = value;
                if (this.frtxtGeneratedScript.InvokeRequired)
                {
                    this.frtxtGeneratedScript.Invoke(new MethodInvoker(vrlAction));
                }
                else
                {
                    vrlAction();
                }
            }
        }

        #region Implementation of I_AdditlionalOptions

        public bool ScriptTriggers
        {
            get
            {
                return this.frbitScriptTrigger.Checked;
            }
        }

        public bool ScriptTableData
        {
            get
            {
                return frbitScriptTableData.Checked;
            }
        }

        public SqlServerVersion ScriptWithDatabaseVersion
        {
            get
            {
                return frintServerVersion.EditValue is SqlServerVersion ? (SqlServerVersion) frintServerVersion.EditValue : SqlServerVersion.Version90;
            }
        }

        public IDictionary<int, string> DatabaseVersion
        {
            set
            {
                this.bsServerVersion.DataSource = value;
            }
        }

        #endregion
    }
}
