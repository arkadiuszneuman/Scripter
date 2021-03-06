﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.Interface
{
    public interface I_AdditlionalOptions
    {
        bool ScriptTriggers { get; }
        bool ScriptTableData { get; }
        SqlServerVersion ScriptWithDatabaseVersion { get; }
        IDictionary<int, string> DatabaseVersion { set; }
    }
}
