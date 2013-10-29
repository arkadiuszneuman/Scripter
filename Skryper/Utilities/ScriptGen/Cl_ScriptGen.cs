using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Utilities.ScriptGen
{
    public class Cl_ScriptGen
    {
        private string serverName, databaseName;
        private int current = 0;
        private Cl_Loader vrcLoader;

        public Cl_ScriptGen(string server, string database)
        {
            this.serverName = server;
            this.databaseName = database;
        }

        public IEnumerable<string> Generate(IEnumerable<Cl_DatabaseObject> vrpObject, Cl_Loader vrpLoader)
        {
            Server server = new Server(serverName);
            Scripter scripter = new Scripter(server);
            scripter.ScriptingProgress += scripter_ScriptingProgress;
            var vrlArray = vrpObject.Select(o => o.SmoObject).ToArray();

            vrpLoader.CreateProgress(0, vrpObject.Count() * 2);
            vrcLoader = vrpLoader;

            scripter.Options = GetDropOptions();
            IEnumerable<string> vrlReturn = scripter.EnumScript(vrlArray);
            scripter.Options = GetOptions();
            vrlReturn = vrlReturn.Union(scripter.EnumScript(vrlArray));

            return vrlReturn;
        }


        private ScriptingOptions GetOptions()
        {
            ScriptingOptions vrlOptions = new ScriptingOptions();
            vrlOptions.IncludeIfNotExists = true;
            vrlOptions.AnsiPadding = false;
            vrlOptions.ContinueScriptingOnError = false;
            vrlOptions.IncludeDatabaseContext = false;
            vrlOptions.ScriptData = false;
            //vrlOptions.ScriptDrops = true;
            vrlOptions.Triggers = false;
            vrlOptions.ScriptSchema = true;
            vrlOptions.IncludeHeaders = false;
            vrlOptions.WithDependencies = false;
            vrlOptions.ExtendedProperties = true;
            vrlOptions.SchemaQualify = true;
            return vrlOptions;
        }

        private ScriptingOptions GetDropOptions()
        {
            ScriptingOptions vrlOptions = GetOptions();
            vrlOptions.ScriptDrops = true;
            return vrlOptions;
        }

        private void scripter_ScriptingProgress(object sender, ProgressReportEventArgs e)
        {
            ++current;
            vrcLoader.ReportProgress(current);
        }
    }
}
