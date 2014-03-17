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
        string GeneratedSql { get; set; }

        IEnumerable<Cl_DatabaseObject> Tables { get; set; }
        IEnumerable<Cl_DatabaseObject> Procedures { get; set; }
        IEnumerable<Cl_DatabaseObject> Functions { get; set; }
        IEnumerable<Cl_DatabaseObject> Views { get; set; }
        IEnumerable<Cl_DatabaseObject> Triggers { get; set; }

        string TablesFileName { get; set; }
        string StoredProceduresFileName { get; set; }
        string ViewsFileName { get; set; }
        string FunctionsFileName { get; set; }
        string TriggersFileName { get; set; }

        bool CheckoutTFS { get; }
    }
}
