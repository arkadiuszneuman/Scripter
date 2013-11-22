using Skryper.Utilities.ScriptGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Utilities
{
    public class Cl_ScriptFilesContainer
    {
        public string TablesFileName { get; set; }
        public string StoredProceduresFileName { get; set; }
        public string ViewsFileName { get; set; }
        public string FunctionsFileName { get; set; }
        public string TriggersFileName { get; set; }

        public List<Cl_DatabaseObject> DatabaseObjects { get; set; }
    }
}
