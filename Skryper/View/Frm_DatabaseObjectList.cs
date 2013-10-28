using inSolutions.Controls.BaseForms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skryper.View
{
    public partial class Frm_DatabaseObjectList : inSolutions.Controls.BaseForms.View.Frm_BaseList
    {
        public Frm_DatabaseObjectList(bool vrpChoose)
            : base(new Dictionary<string, UC_BaseList>(), vrpChoose, true)
        {
            InitializeComponent();
        }
    }
}
