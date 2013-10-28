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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.vruTables = new Skryper.View.UC_TableView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.vruStorageProcedure = new Skryper.View.UC_StorageProcedureView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bsDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.frtxtServerName = new DevExpress.XtraEditors.TextEdit();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.frtxtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.frtxtDatabase = new DevExpress.XtraEditors.LookUpEdit();
            this.uC_DatabaseObjectList1 = new Skryper.View.UC_DatabaseObjectList();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 181);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 181);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 45);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(624, 180);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.vruTables);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(618, 152);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // vruTables
            // 
            this.vruTables.Database = null;
            this.vruTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruTables.Location = new System.Drawing.Point(0, 0);
            this.vruTables.Margin = new System.Windows.Forms.Padding(0);
            this.vruTables.Name = "vruTables";
            this.vruTables.Padding = new System.Windows.Forms.Padding(4);
            this.vruTables.Size = new System.Drawing.Size(618, 152);
            this.vruTables.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.vruStorageProcedure);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(618, 152);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // vruStorageProcedure
            // 
            this.vruStorageProcedure.Database = null;
            this.vruStorageProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vruStorageProcedure.Location = new System.Drawing.Point(0, 0);
            this.vruStorageProcedure.Margin = new System.Windows.Forms.Padding(0);
            this.vruStorageProcedure.Name = "vruStorageProcedure";
            this.vruStorageProcedure.Padding = new System.Windows.Forms.Padding(4);
            this.vruStorageProcedure.Size = new System.Drawing.Size(618, 152);
            this.vruStorageProcedure.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(866, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            // 
            // bsDatabase
            // 
            this.bsDatabase.DataSource = typeof(Microsoft.SqlServer.Management.Smo.Database);
            // 
            // frtxtServerName
            // 
            this.frtxtServerName.Location = new System.Drawing.Point(502, 22);
            this.frtxtServerName.Name = "frtxtServerName";
            this.frtxtServerName.Size = new System.Drawing.Size(100, 20);
            this.frtxtServerName.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(421, 22);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
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
            this.frtxtDatabase.Location = new System.Drawing.Point(633, 22);
            this.frtxtDatabase.Name = "frtxtDatabase";
            this.frtxtDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frtxtDatabase.Properties.NullText = "Wybierz bazę danych";
            this.frtxtDatabase.Size = new System.Drawing.Size(200, 20);
            this.frtxtDatabase.TabIndex = 7;
            this.frtxtDatabase.EditValueChanged += new System.EventHandler(this.frtxtDatabase_EditValueChanged);
            // 
            // uC_DatabaseObjectList1
            // 
            this.uC_DatabaseObjectList1.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList1.LoadDataSource = false;
            this.uC_DatabaseObjectList1.Location = new System.Drawing.Point(53, 242);
            this.uC_DatabaseObjectList1.Name = "uC_DatabaseObjectList1";
            this.uC_DatabaseObjectList1.Size = new System.Drawing.Size(379, 285);
            this.uC_DatabaseObjectList1.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Table;
            this.uC_DatabaseObjectList1.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(398, 242);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(438, 271);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(541, 227);
            this.memoEdit1.TabIndex = 10;
            // 
            // Frm_Skrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1033, 556);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.uC_DatabaseObjectList1);
            this.Controls.Add(this.frtxtDatabase);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.frtxtServerName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Frm_Skrypter";
            this.ShowInTaskbar = true;
            this.Text = "Skrypter";
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.frtxtServerName, 0);
            this.Controls.SetChildIndex(this.btnConnect, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.frtxtDatabase, 0);
            this.Controls.SetChildIndex(this.uC_DatabaseObjectList1, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.memoEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource bsDatabase;
        private DevExpress.XtraEditors.TextEdit frtxtServerName;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel frtxtStatus;
        private UC_TableView vruTables;
        private UC_StorageProcedureView vruStorageProcedure;
        private DevExpress.XtraEditors.LookUpEdit frtxtDatabase;
        private UC_DatabaseObjectList uC_DatabaseObjectList1;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}