using Encrypter;
using Skryper.Utilities.ScriptGen;
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
        private readonly string subdirEncrypted = "\\Files\\Scripts\\Encrypted";
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
            string directoryPath = GetDirectoryPath();
            return File.Exists(directoryPath + subdir + slnConfigFileName);
        }

        public string GetConfigFilePath()
        {
            string directoryPath = GetDirectoryPath();
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

        public void SaveScript(string vrpScript, string sqlFileName)
        {
            string directoryPath = GetDirectoryPath();

            using (StreamWriter vrlStream = new StreamWriter(directoryPath + subdir + sqlFileName))
            {
                vrlStream.Write(vrpScript);
            }
        }

        private string GetDirectoryPath()
        {
            return Path.GetDirectoryName(slnFilePath);
        }

        public string GetEncryptedFilePath(string fileName)
        {
            string vrlToPath = String.Format("{0}\\{1}S{2}", Path.GetDirectoryName(fileName),
                Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName));

            string directoryPath = GetDirectoryPath();
            string vrlSPath = directoryPath + subdirEncrypted + vrlToPath;

            return vrlSPath;
        }

        public string GetFullFilePath(string fileName)
        {
            string directoryPath = GetDirectoryPath();
            return directoryPath + subdir + fileName;
        }

        public void SaveEncryptedFile(string fileName)
        {
            string vrlSPath = GetEncryptedFilePath(fileName);
            
            if (!Directory.Exists(Path.GetDirectoryName(vrlSPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(vrlSPath));
            }

            Cl_Encrypter vrlEncrypter = new Cl_Encrypter();
            vrlEncrypter.EncryptFile(GetFullFilePath(fileName), vrlSPath);
        }

        private Cl_TFS GetTFSObject()
        {
            return new Cl_TFS(Path.GetDirectoryName(slnFilePath));
        }

        public void TFSAddOrCheckoutFile(string filePath)
        {
            Cl_TFS tfs = GetTFSObject();
            tfs.CheckoutFile(filePath);
        }
    }
}
