using Skryper.Interface;
using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Skryper.Utilities.ScriptGen
{
    public class Cl_ScriptGen
    {
        private string serverName, databaseName;
        private readonly I_AdditlionalOptions vrcAdditionalOptions;
        private int current = 0;
        private I_ScriptProgress vrcProgress;

        public Cl_ScriptGen(string server, string database, I_AdditlionalOptions vrpAdditionalOptions)
        {
            this.serverName = server;
            this.databaseName = database;
            vrcAdditionalOptions = vrpAdditionalOptions;
        }

        public string Generate(IEnumerable<Cl_DatabaseObject> vrpObject, I_ScriptProgress vrpProgress)
        {
            Server server = new Server(serverName);
            Scripter scripter = new Scripter(server);
            scripter.ScriptingProgress += scripter_ScriptingProgress;
            var vrlArray = vrpObject.Select(o => o.SmoObject).ToArray();

            CreateProgress(vrpProgress, vrpObject.Count() * 2);

            scripter.Options = GetDropOptions();
            IEnumerable<string> vrlReturn = scripter.EnumScript(vrlArray);
            scripter.Options = GetOptions();
            vrlReturn = vrlReturn.Union(scripter.EnumScript(vrlArray));

            string vrlJoinedString = string.Join(Environment.NewLine + Environment.NewLine, vrlReturn.ToArray());
            vrlJoinedString = RemoveDropTables(vrlJoinedString);
            vrlJoinedString = RemoveAnsiiAndQuotedIndentifier(vrlJoinedString);
            vrlJoinedString = RemoveToManyReturns(vrlJoinedString);

            return vrlJoinedString;
        }

        private string RemoveToManyReturns(string vrlJoinedString)
        {
            return vrlJoinedString.Replace(Environment.NewLine + Environment.NewLine + Environment.NewLine, Environment.NewLine);
        }

        private string RemoveAnsiiAndQuotedIndentifier(string vrlJoinedString)
        {
            string pattern = "SET ANSI_NULLS.*\n";
            string replacement = string.Empty;
            Regex rgx = new Regex(pattern);
            vrlJoinedString = rgx.Replace(vrlJoinedString, replacement);

            pattern = "SET QUOTED_IDENTIFIER.*\n";
            rgx = new Regex(pattern);
            return rgx.Replace(vrlJoinedString, replacement);
        }

        private string RemoveDropTables(string vrlJoinedString)
        {
            string pattern = "IF.*\nDROP TABLE.*\n";
            string replacement = string.Empty;
            Regex rgx = new Regex(pattern);
            return rgx.Replace(vrlJoinedString, replacement);
        }

        private void CreateProgress(I_ScriptProgress vrpProgress, int vrpCount)
        {
            if (vrpProgress != null)
            {
                vrcProgress = vrpProgress;
                vrcProgress.CreateProgress(0, vrpCount);
            }
        }

        private ScriptingOptions GetOptions()
        {
            ScriptingOptions vrlOptions = new ScriptingOptions();
            vrlOptions.IncludeIfNotExists = true;
            vrlOptions.AnsiPadding = false;
            vrlOptions.ContinueScriptingOnError = false;
            vrlOptions.IncludeDatabaseContext = false;
            vrlOptions.ScriptData = false;
            vrlOptions.Triggers = vrcAdditionalOptions.ScriptTriggers;
            vrlOptions.ScriptData = vrcAdditionalOptions.ScriptTableData;
            vrlOptions.TargetServerVersion = vrcAdditionalOptions.ScriptWithDatabaseVersion;
            vrlOptions.ScriptSchema = true;
            vrlOptions.IncludeHeaders = false;
            vrlOptions.WithDependencies = false;
            vrlOptions.ExtendedProperties = true;
            vrlOptions.SchemaQualify = true;
            vrlOptions.Indexes = true;
            vrlOptions.DriIndexes = true;
            vrlOptions.DriAllConstraints = true;
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
            if (vrcProgress != null)
            {
                ++current;
                vrcProgress.ReportProgress(current);
            }
        }
    }
}
