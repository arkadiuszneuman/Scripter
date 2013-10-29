using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Utilities.ScriptGen
{
    public interface I_ScriptProgress
    {
        void CreateProgress(int min, int max);
        void ReportProgress(int vrpProgress);
    }
}
