using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.View
{
    public partial class Frm_Skrypter : Form,I_Database
    {
        #region Private fields

        private readonly ClP_Scirpter vrcPresenter;

        #endregion

        #region Constructor

        public Frm_Skrypter()
        {
            InitializeComponent();
            vrcPresenter = new ClP_Scirpter(this);
        }

        #endregion

        #region Events

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frtxtServerName.Text))
            {
                vrcPresenter.ConnectToServer();

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



        #endregion

    }

    internal class ClP_Scirpter
    {
        private readonly I_Database vrcView;

        public ClP_Scirpter(I_Database vrpView)
        {
            vrcView = vrpView;
        }

        public void ConnectToServer()
        {
            vrcView.Server = new Server(vrcView.ServerName);
            vrcView.ServerStatus = vrcView.Server.Status.ToString();
        }

    }

    public interface I_Database
    {
        DatabaseCollection DatabaseDatasource { get; set; }

        Database Database { get;}

        Server Server { set; get; }

        string ServerName { get; }

        string ServerStatus { set;}
    }
}
