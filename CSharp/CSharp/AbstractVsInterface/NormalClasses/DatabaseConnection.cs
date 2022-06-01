using CSharp.AbstractVsInterface.Interface;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class DatabaseConnection
    {
        public IDatabase _database;
        public DatabaseConnection(IDatabase database)
        {
            _database = database;
        }

        public void ShowConnection()
        {
            _database.ShowDatabaseName();
        }
    }
}
