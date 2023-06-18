using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BadCode.LowCohesion.Bad
{
    internal class LowCohesion
    {
        public void ConnectToDatasource() { }
        public void ExtractDataFromDataSource() { }
        public void TransformDataForReport() { }
        public void AssignDataAndGenerateReport() { }
        public void PrintReport() { }
        public void CloseConnectionToDataSource() { }
    }
}
