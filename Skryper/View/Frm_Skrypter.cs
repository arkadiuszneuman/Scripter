using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Presenter;
using Skryper.Interface;
using System.Collections.Generic;
using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Common;

namespace Skryper.View
{
    public partial class Frm_Skrypter : inSolutions.Controls.BaseForms.View.Frm_EntityBaseForm, I_Scripter
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
            Cl_Loader vrlLoader = new Cl_Loader(Cl_ProgramMessages.ProgramMessages, (l) =>
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(frtxtServerName.Text))
                        {
                            Presenter.ConnectToServer();

                            vruTables.Server = Server;
                            vruStorageProcedure.Server = Server;
                            //vruTables.Database = Server.Databases["nowy"];
                            //vruStorageProcedure.Database = Server.Databases["nowy"];

                            //vruTables.LoadDatasoure();
                            //vruStorageProcedure.LoadDatasoure();
                        }
                    }
                    catch (ConnectionFailureException)
                    {
                        Cl_ProgramMessages.ProgramMessages.Error("Nie można połączyć się z serwerem.");
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
        }


        public string SelectedDatabase
        {
            get { return Convert.ToString(this.frtxtDatabase.EditValue); }
        }
    }
}
