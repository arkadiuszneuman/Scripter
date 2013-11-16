namespace Skryper.StartUp.View
{
    partial class Frm_StartUpPanel
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
            this.frtxtDatabase = new DevExpress.XtraEditors.LookUpEdit();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.frtxtServerName = new DevExpress.XtraEditors.TextEdit();
            this.frtxtSlnPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.btnChooseSln = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.frtxtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(680, 257);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(770, 257);
            // 
            // frtxtDatabase
            // 
            this.frtxtDatabase.Location = new System.Drawing.Point(221, 41);
            this.frtxtDatabase.Name = "frtxtDatabase";
            this.frtxtDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frtxtDatabase.Properties.NullText = "Wybierz bazę danych";
            this.frtxtDatabase.Size = new System.Drawing.Size(200, 20);
            this.frtxtDatabase.TabIndex = 10;
            this.frtxtDatabase.EditValueChanged += new System.EventHandler(this.frtxtDatabase_EditValueChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frtxtServerName
            // 
            this.frtxtServerName.Location = new System.Drawing.Point(90, 41);
            this.frtxtServerName.Name = "frtxtServerName";
            this.frtxtServerName.Size = new System.Drawing.Size(100, 20);
            this.frtxtServerName.TabIndex = 8;
            // 
            // frtxtSlnPath
            // 
            this.frtxtSlnPath.Location = new System.Drawing.Point(66, 31);
            this.frtxtSlnPath.Name = "frtxtSlnPath";
            this.frtxtSlnPath.Size = new System.Drawing.Size(345, 20);
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
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.btnChooseSln);
            this.groupControl6.Controls.Add(this.frtxtSlnPath);
            this.groupControl6.Controls.Add(this.labelControl1);
            this.groupControl6.Location = new System.Drawing.Point(12, 118);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(833, 74);
            this.groupControl6.TabIndex = 15;
            this.groupControl6.Text = "Połączenie z solucją";
            // 
            // btnChooseSln
            // 
            this.btnChooseSln.Location = new System.Drawing.Point(417, 28);
            this.btnChooseSln.Name = "btnChooseSln";
            this.btnChooseSln.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSln.TabIndex = 15;
            this.btnChooseSln.Text = "Wybierz";
            this.btnChooseSln.Click += new System.EventHandler(this.btnChooseSln_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frtxtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frtxtStatus
            // 
            this.frtxtStatus.Name = "frtxtStatus";
            this.frtxtStatus.Size = new System.Drawing.Size(42, 17);
            this.frtxtStatus.Text = "Status:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.frtxtServerName);
            this.groupControl1.Controls.Add(this.btnConnect);
            this.groupControl1.Controls.Add(this.frtxtDatabase);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(833, 100);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Połączenie";
            // 
            // Frm_StartUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 306);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupControl6);
            this.Name = "Frm_StartUpPanel";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Frm_StartUpPanel_Load);
            this.Controls.SetChildIndex(this.groupControl6, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.frtxtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit frtxtDatabase;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.TextEdit frtxtServerName;
        private DevExpress.XtraEditors.TextEdit frtxtSlnPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnChooseSln;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel frtxtStatus;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}