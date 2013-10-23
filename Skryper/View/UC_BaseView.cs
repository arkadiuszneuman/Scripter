using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.View
{
    public partial class UC_BaseView : UserControl
    {
        private Server vrcServer;

        public UC_BaseView()
        {
            InitializeComponent();
        }

        public Server Server
        {
            get
            {
                if (vrcServer != null)
                {
                    return vrcServer;
                }
                else
                {
                    throw new InvalidOperationException("Zainicjuj Server");
                }
            }
            set
            {
                vrcServer = value;
            }
        }

        public Database Database { get; set; }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            frtxtScript.Text = string.Empty;
            
            var vrlSelectedRows = this.gridView1.GetSelectedRows();


            Scripter vrlScripter = new Scripter(Server);
            List<SqlSmoObject> vrlObjects = new List<SqlSmoObject>();
            

            ScriptingOptions vrlOptions = new ScriptingOptions();
            vrlOptions.NoIdentities = frbitNoIdentities.Checked;
            vrlOptions.IncludeIfNotExists = frbitIncludeIfNotExists.Checked;
            vrlOptions.AnsiPadding = frbitAnsiPadding.Checked;
            vrlOptions.ContinueScriptingOnError =frbitContinueScriptingOnError.Checked;
            vrlOptions.IncludeDatabaseContext = frbitIncludeDatabaseContext.Checked;
            vrlOptions.ScriptData = frbitScriptData.Checked;
            vrlOptions.ScriptDrops = frbitScriptDrops.Checked;
            vrlOptions.Triggers = frbitTriggers.Checked;

            vrlScripter.Options = vrlOptions;

            foreach (var vrlSelectedRow in vrlSelectedRows)
            {
               var vrlSmoObjects = this.gridView1.GetRow(vrlSelectedRow) as SqlSmoObject;
               vrlObjects.Add(vrlSmoObjects);
            }


            var vrlResult = vrlScripter.EnumScript(vrlObjects.ToArray());

            frtxtScript.Text = string.Join(Environment.NewLine, vrlResult);
        
        }

        public virtual void LoadDatasoure()
        {
        }



    }
}