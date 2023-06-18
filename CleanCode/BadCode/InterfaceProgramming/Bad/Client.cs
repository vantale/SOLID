using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BadCode.InterfaceProgramming.Bad
{
    public class Client
    {
        public void Execute()
        {
            var mongoDb = new MongoDbConnection();
            var sqlServer = new SqlServerConnection();
            
            var db = new Database(mongoDb);
            db.OpenConnection(); // Otwarto połączenie z MongoDB.
            db.CloseConnection(); // Zamknięto połączenie z MongoDB.

            db = new Database(sqlServer);
            db.OpenConnection(); // Otwarto połączenie z SQL Server.
            db.CloseConnection(); // Zamknięto połączenie z SQL Server.
        }
    }
}
