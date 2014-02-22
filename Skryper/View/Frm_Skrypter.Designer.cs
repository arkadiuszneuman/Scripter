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
            this.vruTables = new Skryper.View.UC_DatabaseObjectList();
            this.vruProcedures = new Skryper.View.UC_DatabaseObjectList();
            this.vruFunctions = new Skryper.View.UC_DatabaseObjectList();
            this.vruViews = new Skryper.View.UC_DatabaseObjectList();
            this.vruTriggers = new Skryper.View.UC_DatabaseObjectList();
            this.bsServerVersion = new System.Windows.Forms.BindingSource(this.components);
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.frbitCheckoutTFS = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtGeneratedScript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtProcedureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTriggerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtViewName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtFunctionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frbitCheckoutTFS.Properties)).BeginInit();
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
            // vruTables
            // 
            this.vruTables.ButtonEditVisibility = false;
            this.vruTables.DefaultName = null;
            this.vruTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruTables.LoadDataSource = false;
            this.vruTables.Location = new System.Drawing.Point(0, 0);
            this.vruTables.Name = "vruTables";
            this.vruTables.Size = new System.Drawing.Size(717, 450);
            this.vruTables.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Table;
            this.vruTables.TabIndex = 8;
            this.vruTables.ViewAddionalColumns = true;
            this.vruTables.ViewNameColumns = true;
            // 
            // vruProcedures
            // 
            this.vruProcedures.ButtonEditVisibility = false;
            this.vruProcedures.DefaultName = null;
            this.vruProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruProcedures.LoadDataSource = false;
            this.vruProcedures.Location = new System.Drawing.Point(0, 0);
            this.vruProcedures.Name = "vruProcedures";
            this.vruProcedures.Size = new System.Drawing.Size(717, 450);
            this.vruProcedures.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.StoredProcedure;
            this.vruProcedures.TabIndex = 8;
            this.vruProcedures.ViewAddionalColumns = false;
            this.vruProcedures.ViewNameColumns = true;
            // 
            // vruFunctions
            // 
            this.vruFunctions.ButtonEditVisibility = false;
            this.vruFunctions.DefaultName = null;
            this.vruFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruFunctions.LoadDataSource = false;
            this.vruFunctions.Location = new System.Drawing.Point(0, 0);
            this.vruFunctions.Name = "vruFunctions";
            this.vruFunctions.Size = new System.Drawing.Size(717, 450);
            this.vruFunctions.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Function;
            this.vruFunctions.TabIndex = 8;
            this.vruFunctions.ViewAddionalColumns = false;
            this.vruFunctions.ViewNameColumns = true;
            // 
            // vruViews
            // 
            this.vruViews.ButtonEditVisibility = false;
            this.vruViews.DefaultName = null;
            this.vruViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruViews.LoadDataSource = false;
            this.vruViews.Location = new System.Drawing.Point(0, 0);
            this.vruViews.Name = "vruViews";
            this.vruViews.Size = new System.Drawing.Size(717, 450);
            this.vruViews.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.View;
            this.vruViews.TabIndex = 8;
            this.vruViews.ViewAddionalColumns = false;
            this.vruViews.ViewNameColumns = true;
            // 
            // vruTriggers
            // 
            this.vruTriggers.ButtonEditVisibility = false;
            this.vruTriggers.DefaultName = null;
            this.vruTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruTriggers.LoadDataSource = false;
            this.vruTriggers.Location = new System.Drawing.Point(0, 0);
            this.vruTriggers.Name = "vruTriggers";
            this.vruTriggers.Size = new System.Drawing.Size(717, 450);
            this.vruTriggers.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Trigger;
            this.vruTriggers.TabIndex = 8;
            this.vruTriggers.ViewAddionalColumns = false;
            this.vruTriggers.ViewNameColumns = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Procedury:";
            // 
            // frtxtProcedureName
            // 
            this.frtxtProcedureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtProcedureName.Location = new System.Drawing.Point(79, 27);
            this.frtxtProcedureName.Name = "frtxtProcedureName";
            this.frtxtProcedureName.Size = new System.Drawing.Size(142, 20);
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
            this.groupControl8.Location = new System.Drawing.Point(741, 35);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(237, 190);
            this.groupControl8.TabIndex = 16;
            this.groupControl8.Text = "Domyślne nazwy plików";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 150);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Triggery:";
            // 
            // frtxtTriggerName
            // 
            this.frtxtTriggerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtTriggerName.Location = new System.Drawing.Point(79, 147);
            this.frtxtTriggerName.Name = "frtxtTriggerName";
            this.frtxtTriggerName.Size = new System.Drawing.Size(142, 20);
            this.frtxtTriggerName.TabIndex = 27;
            this.frtxtTriggerName.EditValueChanged += new System.EventHandler(this.frtxtTriggerName_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Widoki:";
            // 
            // frtxtViewName
            // 
            this.frtxtViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtViewName.Location = new System.Drawing.Point(79, 117);
            this.frtxtViewName.Name = "frtxtViewName";
            this.frtxtViewName.Size = new System.Drawing.Size(142, 20);
            this.frtxtViewName.TabIndex = 25;
            this.frtxtViewName.EditValueChanged += new System.EventHandler(this.frtxtViewName_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Funkcje:";
            // 
            // frtxtFunctionName
            // 
            this.frtxtFunctionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtFunctionName.Location = new System.Drawing.Point(79, 87);
            this.frtxtFunctionName.Name = "frtxtFunctionName";
            this.frtxtFunctionName.Size = new System.Drawing.Size(142, 20);
            this.frtxtFunctionName.TabIndex = 23;
            this.frtxtFunctionName.EditValueChanged += new System.EventHandler(this.frtxtFunctionName_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Tabele:";
            // 
            // frtxtTableName
            // 
            this.frtxtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtTableName.Location = new System.Drawing.Point(79, 57);
            this.frtxtTableName.Name = "frtxtTableName";
            this.frtxtTableName.Size = new System.Drawing.Size(142, 20);
            this.frtxtTableName.TabIndex = 21;
            this.frtxtTableName.EditValueChanged += new System.EventHandler(this.frtxtTableName_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(723, 478);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.vruTables);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(717, 450);
            this.xtraTabPage1.Text = "Tabele";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.vruProcedures);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(717, 450);
            this.xtraTabPage2.Text = "Procedury";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.vruFunctions);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(717, 450);
            this.xtraTabPage3.Text = "Funkcje";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.vruViews);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(717, 450);
            this.xtraTabPage4.Text = "Widoki";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.vruTriggers);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(717, 450);
            this.xtraTabPage5.Text = "Triggery";
            // 
            // frbitCheckoutTFS
            // 
            this.frbitCheckoutTFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.frbitCheckoutTFS.EditValue = true;
            this.frbitCheckoutTFS.Location = new System.Drawing.Point(752, 238);
            this.frbitCheckoutTFS.Name = "frbitCheckoutTFS";
            this.frbitCheckoutTFS.Properties.Caption = "Checkout plików w TFS";
            this.frbitCheckoutTFS.Size = new System.Drawing.Size(139, 19);
            this.frbitCheckoutTFS.TabIndex = 17;
            // 
            // Frm_Skrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(1010, 683);
            this.Controls.Add(this.frbitCheckoutTFS);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl8);
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
            this.Controls.SetChildIndex(this.groupControl8, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.frbitCheckoutTFS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtGeneratedScript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtProcedureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTriggerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtViewName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtFunctionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frbitCheckoutTFS.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDatabase;
        private UC_DatabaseObjectList vruTables;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.MemoEdit frtxtGeneratedScript;
        private UC_DatabaseObjectList vruProcedures;
        private UC_DatabaseObjectList vruFunctions;
        private UC_DatabaseObjectList vruViews;
        private UC_DatabaseObjectList vruTriggers;
        private System.Windows.Forms.BindingSource bsServerVersion;
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
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.CheckEdit frbitCheckoutTFS;
    }
}