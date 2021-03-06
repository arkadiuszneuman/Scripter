﻿using Microsoft.SqlServer.Management.Smo;
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
    }
}
