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
            View.ServerStatus = View.Server.Status.ToString();
        }

        public override void LoadDataSources()
        {
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
