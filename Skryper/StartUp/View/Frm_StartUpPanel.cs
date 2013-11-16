﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Properties;
using Skryper.StartUp.Interface;
using Skryper.StartUp.Presenter;
using Skryper.Utilities;
using Skryper.View;
using inSolutions.Controls.Loader.Utilities;

namespace Skryper.StartUp.View
{
    public partial class Frm_StartUpPanel : inSolutions.Controls.BaseForms.View.Frm_BaseForm, I_StartUpConfiguration
    {
        #region Constructor

        public Frm_StartUpPanel()
        {
            InitializeComponent();
            vrcPresenter = new ClP_StartUp(this);
        } 

        #endregion

        #region Public properties

        public Server Server { get; set; }

        public string ServerStatus
        {
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                this.frtxtStatus.Text = Server != null ? Server.Status.ToString() : Resources.StatusNotConnected;
            }
            get
            {
                return Server != null ? Server.Status.ToString() : Resources.StatusNotConnected;
            }
        }

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

        public string CurrentServerName
        {
            get
            {
                return this.frtxtServerName.Text;
            }
            set
            {
                SetName(frtxtServerName,value);
            }
        }

        private void SetName(Control vrlControl,string vrpServerName)
        {
            Action vrlAction = () => vrlControl.Text = vrpServerName;
            if (this.frtxtServerName.InvokeRequired)
            {
                this.frtxtServerName.Invoke(new MethodInvoker(vrlAction));
            }
            else
            {
                vrlAction();
            }

        }

        public string CurrentDatabaseName
        {
            get
            {
                return Convert.ToString(this.frtxtDatabase.EditValue);
            }
            set
            {
                SetName(frtxtDatabase,value);
            }
        }

        public string SlnPth
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

        public new ClP_StartUp Presenter
        {
            get
            {
                return vrcPresenter as ClP_StartUp;
            }
        }

        #region Implementation of I_EntityBaseForm

        public bool ReturnObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #endregion

        #region Private methods

        protected override void OnSaved()
        {
            Presenter.SaveToConfig();
            Presenter.ShowMain();
        }

        #endregion

        #region Events

        private void frtxtDatabase_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Presenter.Connect();
        }

        

        private void btnChooseSln_Click(object sender, EventArgs e)
        {
            Presenter.ChooseSln();
        }

        private void Frm_StartUpPanel_Load(object sender, EventArgs e)
        {
            frtxtStatus.Text = ServerStatus;
            Presenter.LoadSln();
        }

        #endregion
    }
}