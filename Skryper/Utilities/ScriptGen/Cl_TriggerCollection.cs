using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.Utilities.ScriptGen
{
    public static class Cl_TriggerCollection
    {
        static Cl_TriggerCollection()
        {
            TriggerCollection = new List<Trigger>();
        }

        public static IEnumerable<Trigger> Get(TableCollection vrpTableCollection,bool vrpReset = false)
        {
            if (!TriggerCollection.Any() || vrpReset)
            {
                foreach (var vrlTrigger in vrpTableCollection.Cast<Table>().SelectMany(vrpTable => vrpTable.Triggers.Cast<Trigger>()))
                {
                    try
                    {
                        //Powoduje że obiekty których i tak nie moża utworzyć nie pokazują się na liście
                        var sd = vrlTrigger.TextHeader;
                        TriggerCollection.Add(vrlTrigger);
                    }
                    catch (PropertyCannotBeRetrievedException vrlException)
                    {
                       
                    }
                }
            }

            return TriggerCollection;
        }

        private static List<Trigger> TriggerCollection { get; set; }
    }
}
