using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSelector.Interface
{
    public interface I_DatabaseSelector
    {
        IEnumerable<string> DatabaseList { get; set; }

        string CurrentServerName { get; set; }
        string CurrentDatabaseName { get; set; }

        bool IsSQLAuthentication { get; set; }
        string Login { get; set; }
        string Pass { get; set; }
    }
}
