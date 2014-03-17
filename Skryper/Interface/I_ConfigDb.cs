using Skryper.StartUp.Utilities;
namespace Skryper.Interface
{
    public interface I_ConfigDb
    {
        string CurrentServerName { get; set; }
        string CurrentDatabaseName { get; set; }
        string SlnPth { get; set; }
        E_SlnConfig SlnConfig { get; set; }

        bool IsSQLAuthentication { get; set; }
        string Login { get; set; }
        string Pass { get; set; }
    }
}