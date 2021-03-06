﻿namespace Skryper.View
{
    partial class UC_DatabaseObjectList
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colSmoObject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmoObject1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grvGridView
            // 
            this.grvGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvGridView.Appearance.GroupRow.Options.UseFont = true;
            this.grvGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSmoObject,
            this.colSmoObject1});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "IsNullOrEmpty([SmoObject])";
            this.grvGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.grvGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.grvGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.grvGridView.OptionsBehavior.Editable = false;
            this.grvGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.grvGridView.OptionsCustomization.AllowGroup = false;
            this.grvGridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.grvGridView.OptionsDetail.EnableMasterViewMode = false;
            this.grvGridView.OptionsMenu.EnableColumnMenu = false;
            this.grvGridView.OptionsMenu.EnableFooterMenu = false;
            this.grvGridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.grvGridView.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grvGridView.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grvGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvGridView.OptionsSelection.MultiSelect = true;
            this.grvGridView.OptionsView.ShowAutoFilterRow = true;
            this.grvGridView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControl
            // 
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2204, -11, 250, 350);
            this.layoutControl.Controls.SetChildIndex(this.btnAdd, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnRemove, 0);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = typeof(Skryper.Utilities.ScriptGen.Cl_DatabaseObject);
            // 
            // colSmoObject
            // 
            this.colSmoObject.Caption = "Nazwa";
            this.colSmoObject.FieldName = "Name";
            this.colSmoObject.Name = "colSmoObject";
            this.colSmoObject.Visible = true;
            this.colSmoObject.VisibleIndex = 0;
            // 
            // colSmoObject1
            // 
            this.colSmoObject1.FieldName = "SmoObject";
            this.colSmoObject1.Name = "colSmoObject1";
            // 
            // UC_DatabaseObjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_DatabaseObjectList";
            this.Controls.SetChildIndex(this.layoutControl, 0);
            this.Controls.SetChildIndex(this.grcGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSmoObject;
        private DevExpress.XtraGrid.Columns.GridColumn colSmoObject1;

    }
}
