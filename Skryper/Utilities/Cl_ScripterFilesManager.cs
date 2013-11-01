using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Skryper.Utilities
{
    public class Cl_ScripterFilesManager
    {
        private readonly string subdir = "\\Files\\Scripts\\";
        private readonly string slnConfigFileName = "config.scr";

        public bool IsScripterProjectExists(string slnFilePath)
        {
            string directoryPath = Path.GetDirectoryName(slnFilePath);
            return File.Exists(directoryPath + subdir + slnConfigFileName);
        }
    }
}
