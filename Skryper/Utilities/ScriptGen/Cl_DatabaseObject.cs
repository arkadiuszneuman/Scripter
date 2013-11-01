using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Utilities.ScriptGen
{
    public class Cl_DatabaseObject
    {
        public NamedSmoObject SmoObject { get; set; }
        public string Name { get; set; }
    }
}
