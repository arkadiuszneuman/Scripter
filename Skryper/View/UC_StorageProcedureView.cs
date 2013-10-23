using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.View
{
    public partial class UC_StorageProcedureView : UC_BaseView
    {
        public UC_StorageProcedureView()
        {
            InitializeComponent();
        }

        public override void LoadDatasoure()
        {
            this.bsSmo.DataSource = Database.StoredProcedures;
        }
    }
}
