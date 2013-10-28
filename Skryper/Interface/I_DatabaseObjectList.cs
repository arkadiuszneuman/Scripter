using inSolutions.Controls.BaseForms.Interface;
using Skryper.Utilities.ScriptGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Interface
{
    public interface I_DatabaseObjectList : I_BaseList<Cl_DatabaseObject>
    {
        E_SmoObjectType SmoObjectType { get; }
    }
}
