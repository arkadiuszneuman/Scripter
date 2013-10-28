using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skryper.Utilities
{
    public class Cl_Config
    {
        public readonly string ConfigPath = Application.ExecutablePath + "\\config.conf";

        public void SaveConfig()
        {
            using (StreamWriter vrlStream = new StreamWriter(ConfigPath))
            {
                vrlStream.Write(Connection + ";" + Database);
            }
        }

        public void LoadConfig()
        {
            if (File.Exists(ConfigPath))
            {
                using (StreamReader vrlStream = new StreamReader(ConfigPath))
                {
                    string vrlText = vrlStream.ReadLine();
                    string[] vrlSplitted = vrlText.Split(';');

                    if (vrlSplitted.Count() != 2)
                    {
                        throw new ArgumentException("Nieprawdłowy plik config.");
                    }

                    Connection = vrlSplitted[0];
                    Database = vrlSplitted[1];
                }
            }
        }

        public string Connection { get; set; }
        public string Database { get; set; }
    }
}
