using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Skryper.Utilities.ScriptGen
{
    public class Cl_DatabaseObject
    {
        [XmlIgnore]
        public NamedSmoObject SmoObject { get; set; }
        public string Name { get; set; }
        public E_SmoObjectType Type { get; set; }

        public bool Drop { get; set; }
        public bool InsertData { get; set; }

        public string FileName { get; set; }
        public bool IsDefaultFileName { get; set; }
    }
}
