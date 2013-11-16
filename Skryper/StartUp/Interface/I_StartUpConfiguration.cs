using System.Collections.Generic;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Interface;

namespace Skryper.StartUp.Interface
{
    public interface I_StartUpConfiguration : inSolutions.Controls.BaseForms.Interface.I_EntityBaseForm,I_ConfigDb
    {
        Server Server { set; get; }
        string ServerStatus { set; }
        IEnumerable<string> DatabaseList { get; set; }
    }
}