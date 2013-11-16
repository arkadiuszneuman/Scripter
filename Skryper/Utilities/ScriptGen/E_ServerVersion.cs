using System;
using Microsoft.SqlServer.Management.Smo;

namespace Skryper.Utilities.ScriptGen
{
    public enum E_ServerVersion
    {
        SQL2005 = SqlServerVersions.Version90,
        SQL2008 = SqlServerVersions.Version100,
        SQL2008R2 = SqlServerVersions.Version105,
        SQL2012 = SqlServerVersions.Version110,
        Unknown = SqlServerVersions.Unknown,
    }
}