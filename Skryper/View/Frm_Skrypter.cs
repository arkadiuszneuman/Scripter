﻿using System;
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
            Cl_Loader vrlLoader = new Cl_Loader(Cl_Messages.Messages, (l) =>
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

            uC_DatabaseObjectList1.SetServer(frtxtServerName.Text, Convert.ToString(frtxtDatabase.EditValue));
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Cl_ScriptGen gen = new Cl_ScriptGen(this.frtxtServerName.Text, this.frtxtDatabase.Text);
            memoEdit1.Text = string.Join(Environment.NewLine, gen.Generate(uC_DatabaseObjectList1.DataSource.Select(o => o.SmoObject)).ToArray());
        }
    }
}
