using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skryper.View
{
    public partial class UC_TableView : UC_BaseView
    {
        public UC_TableView()
        {
            InitializeComponent();   
        }

        public override void LoadDatasoure()
        {
            this.bsSmo.DataSource = Database.Tables;
        }
    }
}
