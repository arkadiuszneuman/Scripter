using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Presenter;
using Skryper.Interface;
using System.Collections.Generic;
using Skryper.StartUp.Interface;
using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Common;
using Skryper.Utilities;
using Skryper.Utilities.ScriptGen;
using System.Linq;
using DevExpress.XtraEditors;

namespace Skryper.View
{
    public partial class Frm_Skrypter : inSolutions.Controls.BaseForms.View.Frm_EntityBaseForm, I_Scripter, I_ScriptProgress,I_AdditlionalOptions
    {
        private readonly I_ConfigDb vrcConfigData;

        #region Constructor

        public Frm_Skrypter(I_ConfigDb vrpConfigData)
        {
            vrcConfigData = vrpConfigData;
            InitializeComponent();
            vrcPresenter = new ClP_Skrypter(this, vrpConfigData);
        }

        #endregion

        #region Events

        // Presenter.DatabaseChanged();

        protected override void OnLoad(EventArgs e)
        {
            vruTables.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));
            vruProcedures.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));
            vruFunctions.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));
            vruViews.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));
            vruTriggers.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));
            vruData.SetServer(vrcConfigData.CurrentServerName, (vrcConfigData.CurrentDatabaseName));

            base.OnLoad(e);
        }



        #endregion

        #region Public properties

        public Server Server { get; set; }

        public new ClP_Skrypter Presenter
        {
            get
            {
                return this.vrcPresenter as ClP_Skrypter;
            }
        }

        #endregion

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

        public IEnumerable<Cl_DatabaseObject> Data
        {
            get { return this.vruData.DataSource; }
            set { this.vruData.DataSource = value.ToList(); }
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


        public string TablesFileName
        {
            get
            {
                return this.frtxtTableName.Text;
            }
            set
            {
                this.frtxtTableName.Text = value;
            }
        }

        public string StoredProceduresFileName
        {
            get
            {
                return this.frtxtProcedureName.Text;
            }
            set
            {
                this.frtxtProcedureName.Text = value;
            }
        }

        public string ViewsFileName
        {
            get
            {
                return this.frtxtViewName.Text;
            }
            set
            {
                this.frtxtViewName.Text = value;
            }
        }

        public string FunctionsFileName
        {
            get
            {
                return this.frtxtFunctionName.Text;
            }
            set
            {
                this.frtxtFunctionName.Text = value;
            }
        }

        public string TriggersFileName
        {
            get
            {
                return this.frtxtTriggerName.Text;
            }
            set
            {
                this.frtxtTriggerName.Text = value;
            }
        }

        private void ChangeDefaultFileName(IEnumerable<Cl_DatabaseObject> vrpObjects, string vrpFileName)
        {
            foreach (var vrlObject in vrpObjects.Where(o => o.IsDefaultFileName))
            {
                vrlObject.Name = vrpFileName;
            }
        }

        private void frtxtProcedureName_EditValueChanged(object sender, EventArgs e)
        {
            this.vruProcedures.DefaultName = ((TextEdit)sender).Text;
            ChangeDefaultFileName(this.vruProcedures.DataSource, ((TextEdit)sender).Text);
        }

        private void frtxtTableName_EditValueChanged(object sender, EventArgs e)
        {
            this.vruTables.DefaultName = ((TextEdit)sender).Text;
            ChangeDefaultFileName(this.vruTables.DataSource, ((TextEdit)sender).Text);
        }

        private void frtxtFunctionName_EditValueChanged(object sender, EventArgs e)
        {
            this.vruFunctions.DefaultName = ((TextEdit)sender).Text;
            ChangeDefaultFileName(this.vruFunctions.DataSource, ((TextEdit)sender).Text);
        }

        private void frtxtViewName_EditValueChanged(object sender, EventArgs e)
        {
            this.vruViews.DefaultName = ((TextEdit)sender).Text;
            ChangeDefaultFileName(this.vruViews.DataSource, ((TextEdit)sender).Text);
        }

        private void frtxtTriggerName_EditValueChanged(object sender, EventArgs e)
        {
            this.vruTriggers.DefaultName = ((TextEdit)sender).Text;
            ChangeDefaultFileName(this.vruTriggers.DataSource, ((TextEdit)sender).Text);
        }
    }
}
