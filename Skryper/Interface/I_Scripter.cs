using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Interface
{
    public interface I_Scripter : inSolutions.Controls.BaseForms.Interface.I_EntityBaseForm
    {
        Server Server { set; get; }

        string ServerName { get; }

        string ServerStatus { set; }

        IEnumerable<string> DatabaseList { get; set; }
        string SelectedDatabase { get; }
    }
}
