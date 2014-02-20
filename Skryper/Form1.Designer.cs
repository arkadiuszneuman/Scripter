namespace Skryper
{
    partial class Form1
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
            this.uC_DatabaseSelector1 = new DatabaseSelector.View.UC_DatabaseSelector();
            this.SuspendLayout();
            // 
            // uC_DatabaseSelector1
            // 
            this.uC_DatabaseSelector1.CurrentDatabaseName = "";
            this.uC_DatabaseSelector1.CurrentServerName = "";
            this.uC_DatabaseSelector1.DatabaseList = null;
            this.uC_DatabaseSelector1.IsSQLAuthentication = false;
            this.uC_DatabaseSelector1.Location = new System.Drawing.Point(26, 76);
            this.uC_DatabaseSelector1.Login = "";
            this.uC_DatabaseSelector1.Name = "uC_DatabaseSelector1";
            this.uC_DatabaseSelector1.Pass = "";
            this.uC_DatabaseSelector1.Size = new System.Drawing.Size(338, 117);
            this.uC_DatabaseSelector1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uC_DatabaseSelector1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseSelector.View.UC_DatabaseSelector uC_DatabaseSelector1;
    }
}