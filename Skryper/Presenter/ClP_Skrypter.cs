using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Interface;
using Skryper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Presenter
{
    public class ClP_Skrypter : inSolutions.Controls.BaseForms.Presenter.ClP_EntityBaseForm
    {
        public ClP_Skrypter(I_Scripter vrpView)
            : base(vrpView)
        {
        }

        public void ConnectToServer()
        {
            View.Server = new Server(View.ServerName);
            //View.Server.Configuration.RemoteLoginTimeout
            View.Server.ConnectionContext.ConnectTimeout = 2;
            View.ServerStatus = View.Server.Status.ToString();

            LoadDatabases();
        }

        public override void LoadDataSources()
        {
        }

        private void LoadDatabases()
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(View.ServerName);

            Database[] databases = new Database[server.Databases.Count];
            server.Databases.CopyTo(databases, 0);
            View.DatabaseList = databases.Where(d => !d.IsSystemObject && !d.Name.ToLower().Contains("reportserver")).Select(d => d.Name);
        }

        public I_Scripter View
        {
            get
            {
                return vrcView as I_Scripter;
            }
        }
    }
}
