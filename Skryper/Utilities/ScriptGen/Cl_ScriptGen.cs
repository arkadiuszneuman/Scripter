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

        public Cl_ScriptGen(string server, string database)
        {
            this.serverName = server;
            this.databaseName = database;
        }

        public IEnumerable<string> Generate(IEnumerable<SqlSmoObject> vrpObject)
        {
            Server server = new Server(serverName);
            Scripter scripter = new Scripter(server);
            scripter.Options = GetOptions();
            scripter.ScriptingProgress += scripter_ScriptingProgress;
            return scripter.EnumScript(vrpObject.ToArray());
        }

        private ScriptingOptions GetOptions()
        {
            ScriptingOptions vrlOptions = new ScriptingOptions();
            vrlOptions.IncludeIfNotExists = true;
            vrlOptions.AnsiPadding = false;
            vrlOptions.ContinueScriptingOnError = false;
            vrlOptions.IncludeDatabaseContext = false;
            vrlOptions.ScriptData = false;
            vrlOptions.ScriptDrops = true;
            vrlOptions.Triggers = false;
            vrlOptions.ScriptSchema = true;
            vrlOptions.IncludeHeaders = false;
            vrlOptions.WithDependencies = false;
            return vrlOptions;
        }

        private void scripter_ScriptingProgress(object sender, ProgressReportEventArgs e)
        {
            
        }
    }
}
