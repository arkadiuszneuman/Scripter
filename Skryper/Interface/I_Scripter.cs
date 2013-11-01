using Microsoft.SqlServer.Management.Smo;
using Skryper.Utilities.ScriptGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Interface
{
    public interface I_Scripter : inSolutions.Controls.BaseForms.Interface.I_EntityBaseForm
    {
        Server Server { set; get; }

        string ServerName { get; set; }
        string SelectedDatabase { get; set; }
        string ServerStatus { set; }
        string GeneratedSql { set; }

        IEnumerable<string> DatabaseList { get; set; }

        string SlnPath { get; set; }

        IEnumerable<Cl_DatabaseObject> Tables { get; set; }
        IEnumerable<Cl_DatabaseObject> Procedures { get; set; }
        IEnumerable<Cl_DatabaseObject> Functions { get; set; }
        IEnumerable<Cl_DatabaseObject> Views { get; set; }
        IEnumerable<Cl_DatabaseObject> Triggers { get; set; }
    }
}
