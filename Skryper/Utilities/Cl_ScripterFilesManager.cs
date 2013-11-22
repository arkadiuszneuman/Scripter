﻿using Skryper.Utilities.ScriptGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Skryper.Utilities
{
    public class Cl_ScripterFilesManager
    {
        private readonly string subdir = "\\Files\\Scripts\\";
        private readonly string slnConfigFileName = "config.scripter";
        private readonly string sqlFileName = "Structure.sql";
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

            if (!Directory.Exists(directoryPath + subdir))
            {
                Directory.CreateDirectory(directoryPath + subdir);
            }

            return filePath;
        }

        public Cl_ScriptFilesContainer LoadObjectsFromConfig()
        {
            string path = GetConfigFilePath();

            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Cl_ScriptFilesContainer));
                using (TextReader textReader = new StreamReader(path))
                {
                    return serializer.Deserialize(textReader) as Cl_ScriptFilesContainer;
                }
            }

            return null;
        }

        public void SaveObjectsToConfig(Cl_ScriptFilesContainer vrpContainer)
        {
            string path = GetConfigFilePath();

            XmlSerializer serializer = new XmlSerializer(typeof(Cl_ScriptFilesContainer));
            using (TextWriter textWriter = new StreamWriter(path))
            {
                serializer.Serialize(textWriter, vrpContainer);
            }
        }

        public void SaveScript(string vrpScript)
        {
            string directoryPath = Path.GetDirectoryName(slnFilePath);

            using (StreamWriter vrlStream = new StreamWriter(directoryPath + subdir + sqlFileName))
            {
                vrlStream.Write(vrpScript);
            }
        }
    }
}
