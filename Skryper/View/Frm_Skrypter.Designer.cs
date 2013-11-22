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
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.frintServerVersion = new DevExpress.XtraEditors.LookUpEdit();
            this.bsServerVersion = new System.Windows.Forms.BindingSource(this.components);
            this.frbitScriptTableData = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.vruData = new Skryper.View.UC_DatabaseObjectList();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtProcedureName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtTriggerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtViewName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtFunctionName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtTableName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintServerVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTableData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtProcedureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTriggerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtViewName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtFunctionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTableName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(841, 629);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(923, 629);
            // 
            // bsDatabase
            // 
            this.bsDatabase.DataSource = typeof(Microsoft.SqlServer.Management.Smo.Database);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(923, 467);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frtxtGeneratedScript
            // 
            this.frtxtGeneratedScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtGeneratedScript.Location = new System.Drawing.Point(12, 496);
            this.frtxtGeneratedScript.Name = "frtxtGeneratedScript";
            this.frtxtGeneratedScript.Size = new System.Drawing.Size(990, 175);
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
            this.vruTables.ViewAddionalColumns = true;
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
            this.vruProcedures.ViewAddionalColumns = false;
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
            this.vruFunctions.ViewAddionalColumns = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.vruViews);
            this.groupControl4.Location = new System.Drawing.Point(257, 255);
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
            this.vruViews.ViewAddionalColumns = false;
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
            this.vruTriggers.ViewAddionalColumns = false;
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl2);
            this.groupControl7.Controls.Add(this.frintServerVersion);
            this.groupControl7.Controls.Add(this.frbitScriptTableData);
            this.groupControl7.Location = new System.Drawing.Point(741, 12);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(237, 112);
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
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.vruData);
            this.groupControl6.Location = new System.Drawing.Point(743, 130);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(237, 144);
            this.groupControl6.TabIndex = 16;
            this.groupControl6.Text = "Data";
            // 
            // vruData
            // 
            this.vruData.ButtonEditVisibility = false;
            this.vruData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruData.LoadDataSource = false;
            this.vruData.Location = new System.Drawing.Point(2, 21);
            this.vruData.Name = "vruData";
            this.vruData.Size = new System.Drawing.Size(233, 121);
            this.vruData.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Data;
            this.vruData.TabIndex = 8;
            this.vruData.ViewAddionalColumns = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Procedury:";
            // 
            // frtxtProcedureName
            // 
            this.frtxtProcedureName.Location = new System.Drawing.Point(77, 39);
            this.frtxtProcedureName.Name = "frtxtProcedureName";
            this.frtxtProcedureName.Size = new System.Drawing.Size(100, 20);
            this.frtxtProcedureName.TabIndex = 19;
            this.frtxtProcedureName.EditValueChanged += new System.EventHandler(this.frtxtProcedureName_EditValueChanged);
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.labelControl6);
            this.groupControl8.Controls.Add(this.frtxtTriggerName);
            this.groupControl8.Controls.Add(this.labelControl5);
            this.groupControl8.Controls.Add(this.frtxtViewName);
            this.groupControl8.Controls.Add(this.labelControl4);
            this.groupControl8.Controls.Add(this.frtxtFunctionName);
            this.groupControl8.Controls.Add(this.labelControl3);
            this.groupControl8.Controls.Add(this.frtxtTableName);
            this.groupControl8.Controls.Add(this.labelControl1);
            this.groupControl8.Controls.Add(this.frtxtProcedureName);
            this.groupControl8.Location = new System.Drawing.Point(745, 278);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(237, 169);
            this.groupControl8.TabIndex = 16;
            this.groupControl8.Text = "Domyślne nazwy plików";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Triggery:";
            // 
            // frtxtTriggerName
            // 
            this.frtxtTriggerName.Location = new System.Drawing.Point(77, 137);
            this.frtxtTriggerName.Name = "frtxtTriggerName";
            this.frtxtTriggerName.Size = new System.Drawing.Size(100, 20);
            this.frtxtTriggerName.TabIndex = 27;
            this.frtxtTriggerName.EditValueChanged += new System.EventHandler(this.frtxtTriggerName_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Widoki:";
            // 
            // frtxtViewName
            // 
            this.frtxtViewName.Location = new System.Drawing.Point(77, 114);
            this.frtxtViewName.Name = "frtxtViewName";
            this.frtxtViewName.Size = new System.Drawing.Size(100, 20);
            this.frtxtViewName.TabIndex = 25;
            this.frtxtViewName.EditValueChanged += new System.EventHandler(this.frtxtViewName_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Funkcje:";
            // 
            // frtxtFunctionName
            // 
            this.frtxtFunctionName.Location = new System.Drawing.Point(77, 88);
            this.frtxtFunctionName.Name = "frtxtFunctionName";
            this.frtxtFunctionName.Size = new System.Drawing.Size(100, 20);
            this.frtxtFunctionName.TabIndex = 23;
            this.frtxtFunctionName.EditValueChanged += new System.EventHandler(this.frtxtFunctionName_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Tabele:";
            // 
            // frtxtTableName
            // 
            this.frtxtTableName.Location = new System.Drawing.Point(75, 69);
            this.frtxtTableName.Name = "frtxtTableName";
            this.frtxtTableName.Size = new System.Drawing.Size(100, 20);
            this.frtxtTableName.TabIndex = 21;
            this.frtxtTableName.EditValueChanged += new System.EventHandler(this.frtxtTableName_EditValueChanged);
            // 
            // Frm_Skrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(1010, 683);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.frtxtGeneratedScript);
            this.Controls.Add(this.btnGenerate);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1026, 722);
            this.Name = "Frm_Skrypter";
            this.ShowInTaskbar = true;
            this.Text = "Skrypter";
            this.UseLoader = false;
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.frtxtGeneratedScript, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            this.Controls.SetChildIndex(this.groupControl5, 0);
            this.Controls.SetChildIndex(this.groupControl7, 0);
            this.Controls.SetChildIndex(this.groupControl6, 0);
            this.Controls.SetChildIndex(this.groupControl8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintServerVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptTableData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frtxtProcedureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTriggerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtViewName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtFunctionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTableName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDatabase;
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
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.CheckEdit frbitScriptTableData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit frintServerVersion;
        private System.Windows.Forms.BindingSource bsServerVersion;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private UC_DatabaseObjectList vruData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit frtxtProcedureName;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit frtxtViewName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit frtxtFunctionName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit frtxtTableName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit frtxtTriggerName;
    }
}