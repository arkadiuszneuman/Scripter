using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skryper.Interface;
using Skryper.Utilities.ScriptGen;
using Skryper.Presenter;

namespace Skryper.View
{
    public partial class UC_DatabaseObjectList : inSolutions.Controls.BaseForms.View.UC_FilterableBaseList, I_DatabaseObjectList
    {
        public UC_DatabaseObjectList()
        {
            InitializeComponent();
            this.vrcPresenter = new ClP_DatabaseObjectList(this);
            this.GridView.OptionsBehavior.Editable = true;
        }

        public void SetServer(I_ConfigDb vrpConfigDb)
        {
            Presenter.SetServer(vrpConfigDb);
        }

        public E_SmoObjectType SmoObjectType
        {
            get;
            set;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICollection<Cl_DatabaseObject> DataSource
        {
            get
            {
                return GetDataSource<Cl_DatabaseObject>();
            }
            set
            {
                SetDataSource(value);
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ClP_DatabaseObjectList Presenter
        {
            get
            {
                return this.vrcPresenter as ClP_DatabaseObjectList;
            }
        }

        public bool ViewAddionalColumns
        {
            get
            {
                return colDrop.Visible && colInsertData.Visible;
            }

            set
            {
                colDrop.Visible = colInsertData.Visible = value;
            }
        }

        public bool ViewNameColumns
        {
            get
            {
                return colFileName.Visible && colIsDefaultFileName.Visible;
            }

            set
            {
                colFileName.Visible = colIsDefaultFileName.Visible = value;
            }
        }

        private void repoDefaultFileName_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(repoDefaultFileName.ValueChecked))
            {
                Cl_DatabaseObject vrlObject = this.grvGridView.GetFocusedRow() as Cl_DatabaseObject;
                vrlObject.IsDefaultFileName = true;
                vrlObject.FileName = DefaultName;
            }
        }

        public string DefaultName { get; set; }

        private void repoDefaultFileName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!Convert.ToBoolean(e.NewValue))
            {
                e.Cancel = true;
            }
        }

        private void repoDefaultNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            Cl_DatabaseObject vrlObject = this.grvGridView.GetFocusedRow() as Cl_DatabaseObject;
            vrlObject.IsDefaultFileName = false;
        }
    }
}
