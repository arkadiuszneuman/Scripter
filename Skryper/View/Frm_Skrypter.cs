using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Presenter;
using Skryper.Interface;

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
            if (!string.IsNullOrEmpty(frtxtServerName.Text))
            {
                Presenter.ConnectToServer();

                vruTables.Server = Server;
                vruStorageProcedure.Server = Server;
                vruTables.Database = Server.Databases["nowy"];
                vruStorageProcedure.Database = Server.Databases["nowy"];

                vruTables.LoadDatasoure();
                vruStorageProcedure.LoadDatasoure();
            }            
        }

        #endregion

        #region Public properties

        public Database Database { get; set; }

        public Server Server { get; set; }

        public DatabaseCollection DatabaseDatasource { get; set; }

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


        public ClP_Skrypter Presenter
        {
            get
            {
                return this.vrcPresenter as ClP_Skrypter;
            }
        }
        #endregion

    }
}
