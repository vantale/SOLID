namespace ConsoleApp1.BadCode
{
    public class Database
    {
        private readonly SqlServerConnection _connection;
        public Database(SqlServerConnection connection)
        {
            _connection = connection;
        }

        public void Connect()
        {
            _connection.Connect();
        }
    }

    public class SqlServerConnection
    {
        public void Connect() { }
    }
}
