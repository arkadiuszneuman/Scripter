namespace Skryper.Interface
{
    public interface I_ConfigDb
    {
        string CurrentServerName { get; set; }
        string CurrentDatabaseName { get; set; }
        string SlnPth { get; set; }
    }
}