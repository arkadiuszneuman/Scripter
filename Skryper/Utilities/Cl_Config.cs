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
        public readonly string ConfigPath = Application.StartupPath + "\\config.conf";

        private Cl_Config()
        {
        }

        public void SaveConfig()
        {
            using (StreamWriter vrlStream = new StreamWriter(ConfigPath))
            {
                vrlStream.Write(ServerName + ";" + Database + ";" + IsSQLAuthentication + ";" + Login + ";" + Pass + ";" + SlnPath);
            }
        }

        public void ReloadConfig()
        {
            if (File.Exists(ConfigPath))
            {
                try
                {
                    using (StreamReader vrlStream = new StreamReader(ConfigPath))
                    {
                        string vrlText = vrlStream.ReadLine();
                        string[] vrlSplitted = vrlText.Split(';');

                        if (vrlSplitted.Count() != 6)
                        {
                            throw new ArgumentException("Nieprawdłowy plik config.");
                        }

                        ServerName = vrlSplitted[0];
                        Database = vrlSplitted[1];
                        IsSQLAuthentication = Convert.ToBoolean(vrlSplitted[2]);
                        Login = vrlSplitted[3];
                        Pass = vrlSplitted[4];
                        SlnPath = vrlSplitted[5];
                    }
                }
                catch (ArgumentException)
                {
                    File.Delete(ConfigPath);
                    Application.Restart();
                }
            }
        }

        public static Cl_Config LoadConfig()
        {
            Cl_Config config = new Cl_Config();
            config.ReloadConfig();

            return config;
        }

        public string ServerName { get; set; }
        public string Database { get; set; }
        public bool IsSQLAuthentication { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }

        public string SlnPath { get; set; }
    }
}
