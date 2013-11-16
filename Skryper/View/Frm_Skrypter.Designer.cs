namespace Skryper.View
{
    partial class Frm_Skrypter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.frtxtServerName = new DevExpress.XtraEditors.TextEdit();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.frtxtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.frtxtDatabase = new DevExpress.XtraEditors.LookUpEdit();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.frtxtGeneratedScript = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.vruTables = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.vruProcedures = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.vruFunctions = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.vruViews = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.vruTriggers = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.btnChooseSln = new DevExpress.XtraEditors.SimpleButton();
            this.frtxtSlnPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.frintServerVersion = new DevExpress.XtraEditors.LookUpEdit();
            this.bsServerVersion = new System.Windows.Forms.BindingSource(this.components);
            this.frbitScriptTableData = new DevExpress.XtraEditors.CheckEdit();
            this.frbitScriptTrigger = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtGeneratedScript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintServerVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTableData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTrigger.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 459);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(627, 459);
            // 
            // bsDatabase
            // 
            this.bsDatabase.DataSource = typeof(Microsoft.SqlServer.Management.Smo.Database);
            // 
            // frtxtServerName
            // 
            this.frtxtServerName.Location = new System.Drawing.Point(980, 27);
            this.frtxtServerName.Name = "frtxtServerName";
            this.frtxtServerName.Size = new System.Drawing.Size(100, 20);
            this.frtxtServerName.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(899, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frtxtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 812);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1434, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frtxtStatus
            // 
            this.frtxtStatus.Name = "frtxtStatus";
            this.frtxtStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frtxtDatabase
            // 
            this.frtxtDatabase.Location = new System.Drawing.Point(1111, 27);
            this.frtxtDatabase.Name = "frtxtDatabase";
            this.frtxtDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frtxtDatabase.Properties.NullText = "Wybierz bazę danych";
            this.frtxtDatabase.Size = new System.Drawing.Size(200, 20);
            this.frtxtDatabase.TabIndex = 7;
            this.frtxtDatabase.EditValueChanged += new System.EventHandler(this.frtxtDatabase_EditValueChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(767, 233);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frtxtGeneratedScript
            // 
            this.frtxtGeneratedScript.Location = new System.Drawing.Point(13, 538);
            this.frtxtGeneratedScript.Name = "frtxtGeneratedScript";
            this.frtxtGeneratedScript.Size = new System.Drawing.Size(1013, 271);
            this.frtxtGeneratedScript.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.vruTables);
            this.groupControl1.Location = new System.Drawing.Point(255, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(237, 237);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Tabele";
            // 
            // vruTables
            // 
            this.vruTables.ButtonEditVisibility = false;
            this.vruTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruTables.LoadDataSource = false;
            this.vruTables.Location = new System.Drawing.Point(2, 21);
            this.vruTables.Name = "vruTables";
            this.vruTables.Size = new System.Drawing.Size(233, 214);
            this.vruTables.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Table;
            this.vruTables.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.vruProcedures);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(237, 480);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Procedury";
            // 
            // vruProcedures
            // 
            this.vruProcedures.ButtonEditVisibility = false;
            this.vruProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruProcedures.LoadDataSource = false;
            this.vruProcedures.Location = new System.Drawing.Point(2, 21);
            this.vruProcedures.Name = "vruProcedures";
            this.vruProcedures.Size = new System.Drawing.Size(233, 457);
            this.vruProcedures.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.StoredProcedure;
            this.vruProcedures.TabIndex = 8;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.vruFunctions);
            this.groupControl3.Location = new System.Drawing.Point(498, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(237, 237);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Funkcje";
            // 
            // vruFunctions
            // 
            this.vruFunctions.ButtonEditVisibility = false;
            this.vruFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruFunctions.LoadDataSource = false;
            this.vruFunctions.Location = new System.Drawing.Point(2, 21);
            this.vruFunctions.Name = "vruFunctions";
            this.vruFunctions.Size = new System.Drawing.Size(233, 214);
            this.vruFunctions.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Function;
            this.vruFunctions.TabIndex = 8;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.vruViews);
            this.groupControl4.Location = new System.Drawing.Point(253, 255);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(237, 237);
            this.groupControl4.TabIndex = 13;
            this.groupControl4.Text = "Widoki";
            // 
            // vruViews
            // 
            this.vruViews.ButtonEditVisibility = false;
            this.vruViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruViews.LoadDataSource = false;
            this.vruViews.Location = new System.Drawing.Point(2, 21);
            this.vruViews.Name = "vruViews";
            this.vruViews.Size = new System.Drawing.Size(233, 214);
            this.vruViews.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.View;
            this.vruViews.TabIndex = 8;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.vruTriggers);
            this.groupControl5.Location = new System.Drawing.Point(500, 255);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(237, 237);
            this.groupControl5.TabIndex = 13;
            this.groupControl5.Text = "Triggery";
            // 
            // vruTriggers
            // 
            this.vruTriggers.ButtonEditVisibility = false;
            this.vruTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruTriggers.LoadDataSource = false;
            this.vruTriggers.Location = new System.Drawing.Point(2, 21);
            this.vruTriggers.Name = "vruTriggers";
            this.vruTriggers.Size = new System.Drawing.Size(233, 214);
            this.vruTriggers.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Trigger;
            this.vruTriggers.TabIndex = 8;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.btnChooseSln);
            this.groupControl6.Controls.Add(this.frtxtSlnPath);
            this.groupControl6.Controls.Add(this.labelControl1);
            this.groupControl6.Location = new System.Drawing.Point(767, 81);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(636, 146);
            this.groupControl6.TabIndex = 14;
            this.groupControl6.Text = "Połączenie z solucją";
            // 
            // btnChooseSln
            // 
            this.btnChooseSln.Location = new System.Drawing.Point(546, 28);
            this.btnChooseSln.Name = "btnChooseSln";
            this.btnChooseSln.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSln.TabIndex = 15;
            this.btnChooseSln.Text = "Wybierz";
            this.btnChooseSln.Click += new System.EventHandler(this.btnChooseSln_Click);
            // 
            // frtxtSlnPath
            // 
            this.frtxtSlnPath.Location = new System.Drawing.Point(66, 31);
            this.frtxtSlnPath.Name = "frtxtSlnPath";
            this.frtxtSlnPath.Size = new System.Drawing.Size(452, 20);
            this.frtxtSlnPath.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Solucja:";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl2);
            this.groupControl7.Controls.Add(this.frintServerVersion);
            this.groupControl7.Controls.Add(this.frbitScriptTableData);
            this.groupControl7.Controls.Add(this.frbitScriptTrigger);
            this.groupControl7.Location = new System.Drawing.Point(883, 310);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(238, 182);
            this.groupControl7.TabIndex = 15;
            this.groupControl7.Text = "Dodatkowe opcje";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Server version:";
            // 
            // frintServerVersion
            // 
            this.frintServerVersion.Location = new System.Drawing.Point(100, 87);
            this.frintServerVersion.Name = "frintServerVersion";
            this.frintServerVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frintServerVersion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Key", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.frintServerVersion.Properties.DataSource = this.bsServerVersion;
            this.frintServerVersion.Properties.NullText = "Wybierz";
            this.frintServerVersion.Size = new System.Drawing.Size(115, 20);
            this.frintServerVersion.TabIndex = 2;
            // 
            // frbitScriptTableData
            // 
            this.frbitScriptTableData.Location = new System.Drawing.Point(20, 60);
            this.frbitScriptTableData.Name = "frbitScriptTableData";
            this.frbitScriptTableData.Properties.Caption = "Script table data";
            this.frbitScriptTableData.Size = new System.Drawing.Size(108, 19);
            this.frbitScriptTableData.TabIndex = 1;
            // 
            // frbitScriptTrigger
            // 
            this.frbitScriptTrigger.Location = new System.Drawing.Point(20, 30);
            this.frbitScriptTrigger.Name = "frbitScriptTrigger";
            this.frbitScriptTrigger.Properties.Caption = "Trigger";
            this.frbitScriptTrigger.Size = new System.Drawing.Size(75, 19);
            this.frbitScriptTrigger.TabIndex = 0;
            // 
            // Frm_Skrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(1434, 834);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.frtxtGeneratedScript);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.frtxtDatabase);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.frtxtServerName);
            this.Name = "Frm_Skrypter";
            this.ShowInTaskbar = true;
            this.Text = "Skrypter";
            this.UseLoader = false;
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.frtxtServerName, 0);
            this.Controls.SetChildIndex(this.btnConnect, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.frtxtDatabase, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.frtxtGeneratedScript, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            this.Controls.SetChildIndex(this.groupControl5, 0);
            this.Controls.SetChildIndex(this.groupControl6, 0);
            this.Controls.SetChildIndex(this.groupControl7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtGeneratedScript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintServerVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTableData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTrigger.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDatabase;
        private DevExpress.XtraEditors.TextEdit frtxtServerName;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel frtxtStatus;
        private DevExpress.XtraEditors.LookUpEdit frtxtDatabase;
        private UC_DatabaseObjectList vruTables;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.MemoEdit frtxtGeneratedScript;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UC_DatabaseObjectList vruProcedures;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UC_DatabaseObjectList vruFunctions;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private UC_DatabaseObjectList vruViews;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private UC_DatabaseObjectList vruTriggers;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnChooseSln;
        private DevExpress.XtraEditors.TextEdit frtxtSlnPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.CheckEdit frbitScriptTableData;
        private DevExpress.XtraEditors.CheckEdit frbitScriptTrigger;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit frintServerVersion;
        private System.Windows.Forms.BindingSource bsServerVersion;
    }
}