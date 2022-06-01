using AbstractAndInterface.InterfaceDemo.Interface;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
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
