namespace CleanCode.BadCode.InterfaceProgramming.Bad
{
    internal class Database
    {
        private MongoDbConnection mongoDb;
        private SqlServerConnection sqlServer;

        public Database(MongoDbConnection mongoDb)
        {
            this.mongoDb = mongoDb;
        }

        public Database(SqlServerConnection sqlServer)
        {
            this.sqlServer = sqlServer;
        }

        internal void OpenConnection()
        {
            throw new NotImplementedException();
        }

        internal void CloseConnection()
        {
            throw new NotImplementedException();
        }
    }
}