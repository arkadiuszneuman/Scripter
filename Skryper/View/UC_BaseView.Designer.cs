namespace Skryper.View
{
    partial class UC_BaseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grpOptions = new DevExpress.XtraEditors.GroupControl();
            this.btnOptions = new DevExpress.XtraEditors.SimpleButton();
            this.frbitScriptDrops = new DevExpress.XtraEditors.CheckEdit();
            this.frbitNoIdentities = new DevExpress.XtraEditors.CheckEdit();
            this.frbitTriggers = new DevExpress.XtraEditors.CheckEdit();
            this.frbitScriptData = new DevExpress.XtraEditors.CheckEdit();
            this.frbitIncludeIfNotExists = new DevExpress.XtraEditors.CheckEdit();
            this.frbitIncludeDatabaseContext = new DevExpress.XtraEditors.CheckEdit();
            this.frbitContinueScriptingOnError = new DevExpress.XtraEditors.CheckEdit();
            this.frbitAnsiPadding = new DevExpress.XtraEditors.CheckEdit();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.splControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.grcSmoObjects = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.frtxtScript = new DevExpress.XtraEditors.MemoEdit();
            this.bsSmo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptDrops.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitNoIdentities.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitTriggers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitIncludeIfNotExists.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitIncludeDatabaseContext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitContinueScriptingOnError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitAnsiPadding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splControl)).BeginInit();
            this.splControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcSmoObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtScript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.grpOptions);
            this.groupControl1.Controls.Add(this.splControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(774, 463);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.btnOptions);
            this.grpOptions.Controls.Add(this.frbitScriptDrops);
            this.grpOptions.Controls.Add(this.frbitNoIdentities);
            this.grpOptions.Controls.Add(this.frbitTriggers);
            this.grpOptions.Controls.Add(this.frbitScriptData);
            this.grpOptions.Controls.Add(this.frbitIncludeIfNotExists);
            this.grpOptions.Controls.Add(this.frbitIncludeDatabaseContext);
            this.grpOptions.Controls.Add(this.frbitContinueScriptingOnError);
            this.grpOptions.Controls.Add(this.frbitAnsiPadding);
            this.grpOptions.Controls.Add(this.btnGenerate);
            this.grpOptions.Location = new System.Drawing.Point(2, 2);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(770, 103);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.Text = "Ustawienia";
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(690, 55);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Opcje";
            // 
            // frbitScriptDrops
            // 
            this.frbitScriptDrops.Location = new System.Drawing.Point(538, 32);
            this.frbitScriptDrops.Name = "frbitScriptDrops";
            this.frbitScriptDrops.Properties.Caption = "ScriptDrops";
            this.frbitScriptDrops.Size = new System.Drawing.Size(75, 19);
            this.frbitScriptDrops.TabIndex = 8;
            // 
            // frbitNoIdentities
            // 
            this.frbitNoIdentities.Location = new System.Drawing.Point(538, 60);
            this.frbitNoIdentities.Name = "frbitNoIdentities";
            this.frbitNoIdentities.Properties.Caption = "NoIdentities";
            this.frbitNoIdentities.Size = new System.Drawing.Size(99, 19);
            this.frbitNoIdentities.TabIndex = 7;
            // 
            // frbitTriggers
            // 
            this.frbitTriggers.Location = new System.Drawing.Point(413, 60);
            this.frbitTriggers.Name = "frbitTriggers";
            this.frbitTriggers.Properties.Caption = "Triggers";
            this.frbitTriggers.Size = new System.Drawing.Size(75, 19);
            this.frbitTriggers.TabIndex = 6;
            // 
            // frbitScriptData
            // 
            this.frbitScriptData.Location = new System.Drawing.Point(413, 30);
            this.frbitScriptData.Name = "frbitScriptData";
            this.frbitScriptData.Properties.Caption = "ScriptData";
            this.frbitScriptData.Size = new System.Drawing.Size(75, 19);
            this.frbitScriptData.TabIndex = 5;
            // 
            // frbitIncludeIfNotExists
            // 
            this.frbitIncludeIfNotExists.Location = new System.Drawing.Point(234, 60);
            this.frbitIncludeIfNotExists.Name = "frbitIncludeIfNotExists";
            this.frbitIncludeIfNotExists.Properties.Caption = "IncludeIfNotExists";
            this.frbitIncludeIfNotExists.Size = new System.Drawing.Size(121, 19);
            this.frbitIncludeIfNotExists.TabIndex = 4;
            // 
            // frbitIncludeDatabaseContext
            // 
            this.frbitIncludeDatabaseContext.Location = new System.Drawing.Point(234, 30);
            this.frbitIncludeDatabaseContext.Name = "frbitIncludeDatabaseContext";
            this.frbitIncludeDatabaseContext.Properties.Caption = "IncludeDatabaseContext";
            this.frbitIncludeDatabaseContext.Size = new System.Drawing.Size(145, 19);
            this.frbitIncludeDatabaseContext.TabIndex = 3;
            // 
            // frbitContinueScriptingOnError
            // 
            this.frbitContinueScriptingOnError.Location = new System.Drawing.Point(20, 60);
            this.frbitContinueScriptingOnError.Name = "frbitContinueScriptingOnError";
            this.frbitContinueScriptingOnError.Properties.Caption = "ContinueScriptingOnError";
            this.frbitContinueScriptingOnError.Size = new System.Drawing.Size(147, 19);
            this.frbitContinueScriptingOnError.TabIndex = 2;
            // 
            // frbitAnsiPadding
            // 
            this.frbitAnsiPadding.Location = new System.Drawing.Point(20, 30);
            this.frbitAnsiPadding.Name = "frbitAnsiPadding";
            this.frbitAnsiPadding.Properties.Caption = "AnsiPadding";
            this.frbitAnsiPadding.Size = new System.Drawing.Size(89, 19);
            this.frbitAnsiPadding.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(690, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // splControl
            // 
            this.splControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splControl.Location = new System.Drawing.Point(2, 111);
            this.splControl.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.splControl.Name = "splControl";
            this.splControl.Panel1.Controls.Add(this.grcSmoObjects);
            this.splControl.Panel1.Padding = new System.Windows.Forms.Padding(1);
            this.splControl.Panel1.Text = "Panel1";
            this.splControl.Panel2.Controls.Add(this.frtxtScript);
            this.splControl.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splControl.Panel2.Text = "Panel2";
            this.splControl.Size = new System.Drawing.Size(770, 350);
            this.splControl.SplitterPosition = 360;
            this.splControl.TabIndex = 1;
            this.splControl.Text = "splitContainerControl1";
            // 
            // grcSmoObjects
            // 
            this.grcSmoObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcSmoObjects.Location = new System.Drawing.Point(1, 1);
            this.grcSmoObjects.MainView = this.gridView1;
            this.grcSmoObjects.Margin = new System.Windows.Forms.Padding(0);
            this.grcSmoObjects.Name = "grcSmoObjects";
            this.grcSmoObjects.Size = new System.Drawing.Size(358, 348);
            this.grcSmoObjects.TabIndex = 0;
            this.grcSmoObjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grcSmoObjects;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frtxtScript
            // 
            this.frtxtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frtxtScript.Location = new System.Drawing.Point(1, 1);
            this.frtxtScript.Margin = new System.Windows.Forms.Padding(0);
            this.frtxtScript.Name = "frtxtScript";
            this.frtxtScript.Size = new System.Drawing.Size(403, 348);
            this.frtxtScript.TabIndex = 0;
            // 
            // UC_BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_BaseView";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(774, 463);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).EndInit();
            this.grpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptDrops.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitNoIdentities.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitTriggers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitScriptData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitIncludeIfNotExists.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitIncludeDatabaseContext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitContinueScriptingOnError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitAnsiPadding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splControl)).EndInit();
            this.splControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcSmoObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtScript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grpOptions;
        private DevExpress.XtraEditors.SplitContainerControl splControl;
        private DevExpress.XtraEditors.MemoEdit frtxtScript;
        protected System.Windows.Forms.BindingSource bsSmo;
        protected DevExpress.XtraGrid.GridControl grcSmoObjects;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.CheckEdit frbitAnsiPadding;
        private DevExpress.XtraEditors.CheckEdit frbitIncludeDatabaseContext;
        private DevExpress.XtraEditors.CheckEdit frbitContinueScriptingOnError;
        private DevExpress.XtraEditors.CheckEdit frbitTriggers;
        private DevExpress.XtraEditors.CheckEdit frbitScriptData;
        private DevExpress.XtraEditors.CheckEdit frbitIncludeIfNotExists;
        private DevExpress.XtraEditors.CheckEdit frbitNoIdentities;
        private DevExpress.XtraEditors.CheckEdit frbitScriptDrops;
        private DevExpress.XtraEditors.SimpleButton btnOptions;
    }
}
