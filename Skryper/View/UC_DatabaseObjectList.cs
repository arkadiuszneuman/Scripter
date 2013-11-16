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
        }

        public void SetServer(string server, string database)
        {
            Presenter.SetServer(server, database);
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
    }
}
