using Skryper.Utilities.ScriptGen;
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
        private readonly string slnConfigFileName = "config.scripter";
        private readonly string slnFilePath;

        public Cl_ScripterFilesManager(string slnFilePath)
        {
            if (!File.Exists(slnFilePath))
            {
                throw new InvalidOperationException("Nieprawidłowa ścieżka do pliku solucji.");
            }

            this.slnFilePath = slnFilePath;
        }

        public bool IsScripterProjectExists()
        {
            string directoryPath = Path.GetDirectoryName(slnFilePath);
            return File.Exists(directoryPath + subdir + slnConfigFileName);
        }

        public string GetConfigFilePath()
        {
            string directoryPath = Path.GetDirectoryName(slnFilePath);
            string filePath = directoryPath + subdir + slnConfigFileName;

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            return filePath;
        }

        public IEnumerable<Cl_DatabaseObject> GetTables()
        {
            string path = GetConfigFilePath();

            return null;
        }
    }
}
