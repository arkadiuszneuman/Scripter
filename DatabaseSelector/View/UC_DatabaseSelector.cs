using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DatabaseSelector.Presenter;
using DatabaseSelector.Interface;
using inSolutions.Controls.BaseForms.Utilities;
using inSolutions.Controls.Administration.Utilities;

namespace DatabaseSelector.View
{
    public partial class UC_DatabaseSelector : XtraUserControl, I_DatabaseSelector
    {
        private ClP_DatabaseSelector vrcPresenter;
        private bool vrcIsLoading = true;

        public UC_DatabaseSelector()
        {
            InitializeComponent();
            vrcPresenter = new ClP_DatabaseSelector(this);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            vrcIsLoading = true;
            base.OnHandleCreated(e);

            if (!DesignMode)
            {
                vrcPresenter.LoadDataSources();
            }

            vrcIsLoading = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            vrcPresenter.Connect();
        }

        private void frtxtDatabase_EditValueChanged(object sender, EventArgs e)
        {
            if (!vrcIsLoading)
            {
                vrcPresenter.SaveToConfig();
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cl_ControlsBlocker vrlBlocker = new Cl_ControlsBlocker();
            vrlBlocker.BlockControl(txtLogin, Convert.ToInt32(radioGroup1.EditValue) == 0);
            vrlBlocker.BlockControl(txtPass, Convert.ToInt32(radioGroup1.EditValue) == 0);
        }


        public bool IsSQLAuthentication
        {
            get { return radioGroup1.SelectedIndex == 1; }
            set
            {
                Action action;

                if (value)
                {
                    action = () => radioGroup1.SelectedIndex = 1;
                }
                else
                {
                    action = () => radioGroup1.SelectedIndex = 0;
                }

                if (radioGroup1.InvokeRequired)
                {
                    radioGroup1.Invoke(new MethodInvoker(action));
                }
                else
                {
                    action();
                }
            }
        }

        public string Login
        {
            get { return txtLogin.Text.Trim(); }
            set
            {
                Action action = () => txtLogin.Text = value;
                if (txtLogin.InvokeRequired)
                {
                    txtLogin.Invoke(new MethodInvoker(action));
                }
                else
                {
                    action();
                }
            }
        }

        public string Pass
        {
            get { return txtPass.Text.Trim(); }
            set
            {
                Action action = () => txtPass.Text = value;
                if (txtPass.InvokeRequired)
                {
                    txtPass.Invoke(new MethodInvoker(action));
                }
                else
                {
                    action();
                }
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
                SetName(frtxtServerName, value);
            }
        }

        private void SetName(Control vrlControl, string vrpServerName)
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
                Action vrlAction = () => frtxtDatabase.EditValue = value;
                if (this.frtxtServerName.InvokeRequired)
                {
                    this.frtxtServerName.Invoke(new MethodInvoker(vrlAction));
                }
                else
                {
                    vrlAction();
                }
            }
        }

        public string GetConnectionString()
        {
            return vrcPresenter.GetServerConnection().ConnectionString + ";initial catalog=" + CurrentDatabaseName;
        }
    }
}
