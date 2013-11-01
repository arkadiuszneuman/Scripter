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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.uC_DatabaseObjectList1 = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.uC_DatabaseObjectList2 = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.uC_DatabaseObjectList3 = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.uC_DatabaseObjectList4 = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.uC_DatabaseObjectList5 = new Skryper.View.UC_DatabaseObjectList();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtSlnPath = new DevExpress.XtraEditors.TextEdit();
            this.btnChooseSln = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
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
            this.btnGenerate.Location = new System.Drawing.Point(752, 33);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(13, 538);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(1013, 271);
            this.memoEdit1.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.uC_DatabaseObjectList1);
            this.groupControl1.Location = new System.Drawing.Point(255, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(237, 237);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Tabele";
            // 
            // uC_DatabaseObjectList1
            // 
            this.uC_DatabaseObjectList1.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatabaseObjectList1.LoadDataSource = false;
            this.uC_DatabaseObjectList1.Location = new System.Drawing.Point(2, 21);
            this.uC_DatabaseObjectList1.Name = "uC_DatabaseObjectList1";
            this.uC_DatabaseObjectList1.Size = new System.Drawing.Size(233, 214);
            this.uC_DatabaseObjectList1.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Table;
            this.uC_DatabaseObjectList1.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.uC_DatabaseObjectList2);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(237, 480);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Procedury";
            // 
            // uC_DatabaseObjectList2
            // 
            this.uC_DatabaseObjectList2.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatabaseObjectList2.LoadDataSource = false;
            this.uC_DatabaseObjectList2.Location = new System.Drawing.Point(2, 21);
            this.uC_DatabaseObjectList2.Name = "uC_DatabaseObjectList2";
            this.uC_DatabaseObjectList2.Size = new System.Drawing.Size(233, 457);
            this.uC_DatabaseObjectList2.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.StoredProcedure;
            this.uC_DatabaseObjectList2.TabIndex = 8;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.uC_DatabaseObjectList3);
            this.groupControl3.Location = new System.Drawing.Point(498, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(237, 237);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Funkcje";
            // 
            // uC_DatabaseObjectList3
            // 
            this.uC_DatabaseObjectList3.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatabaseObjectList3.LoadDataSource = false;
            this.uC_DatabaseObjectList3.Location = new System.Drawing.Point(2, 21);
            this.uC_DatabaseObjectList3.Name = "uC_DatabaseObjectList3";
            this.uC_DatabaseObjectList3.Size = new System.Drawing.Size(233, 214);
            this.uC_DatabaseObjectList3.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Function;
            this.uC_DatabaseObjectList3.TabIndex = 8;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.uC_DatabaseObjectList4);
            this.groupControl4.Location = new System.Drawing.Point(253, 255);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(237, 237);
            this.groupControl4.TabIndex = 13;
            this.groupControl4.Text = "Widoki";
            // 
            // uC_DatabaseObjectList4
            // 
            this.uC_DatabaseObjectList4.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatabaseObjectList4.LoadDataSource = false;
            this.uC_DatabaseObjectList4.Location = new System.Drawing.Point(2, 21);
            this.uC_DatabaseObjectList4.Name = "uC_DatabaseObjectList4";
            this.uC_DatabaseObjectList4.Size = new System.Drawing.Size(233, 214);
            this.uC_DatabaseObjectList4.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.View;
            this.uC_DatabaseObjectList4.TabIndex = 8;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.uC_DatabaseObjectList5);
            this.groupControl5.Location = new System.Drawing.Point(500, 255);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(237, 237);
            this.groupControl5.TabIndex = 13;
            this.groupControl5.Text = "Triggery";
            // 
            // uC_DatabaseObjectList5
            // 
            this.uC_DatabaseObjectList5.ButtonEditVisibility = false;
            this.uC_DatabaseObjectList5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatabaseObjectList5.LoadDataSource = false;
            this.uC_DatabaseObjectList5.Location = new System.Drawing.Point(2, 21);
            this.uC_DatabaseObjectList5.Name = "uC_DatabaseObjectList5";
            this.uC_DatabaseObjectList5.Size = new System.Drawing.Size(233, 214);
            this.uC_DatabaseObjectList5.SmoObjectType = Skryper.Utilities.ScriptGen.E_SmoObjectType.Trigger;
            this.uC_DatabaseObjectList5.TabIndex = 8;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.btnChooseSln);
            this.groupControl6.Controls.Add(this.frtxtSlnPath);
            this.groupControl6.Controls.Add(this.labelControl1);
            this.groupControl6.Location = new System.Drawing.Point(767, 81);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(636, 66);
            this.groupControl6.TabIndex = 14;
            this.groupControl6.Text = "Połączenie z solucją";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Solucja:";
            // 
            // frtxtSlnPath
            // 
            this.frtxtSlnPath.Location = new System.Drawing.Point(66, 31);
            this.frtxtSlnPath.Name = "frtxtSlnPath";
            this.frtxtSlnPath.Size = new System.Drawing.Size(452, 20);
            this.frtxtSlnPath.TabIndex = 1;
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
            // Frm_Skrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(1434, 834);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.memoEdit1);
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
            this.Controls.SetChildIndex(this.memoEdit1, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            this.Controls.SetChildIndex(this.groupControl5, 0);
            this.Controls.SetChildIndex(this.groupControl6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
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
        private UC_DatabaseObjectList uC_DatabaseObjectList1;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UC_DatabaseObjectList uC_DatabaseObjectList2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UC_DatabaseObjectList uC_DatabaseObjectList3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private UC_DatabaseObjectList uC_DatabaseObjectList4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private UC_DatabaseObjectList uC_DatabaseObjectList5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnChooseSln;
        private DevExpress.XtraEditors.TextEdit frtxtSlnPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}