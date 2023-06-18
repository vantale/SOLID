using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BadCode.LowCohesion.Good
{
    public class Connection
    {
        public void ConnectToDatasource() { }
        public void CloseConnectionToDataSource() { }
    }
}
