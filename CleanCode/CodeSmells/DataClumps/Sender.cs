using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.DataClumps
{
    internal class Sender
    {
        public string SenderForeName { get; set; }
        public string SenderFamilyName { get; set; }
        public string SenderAddressStreetName { get; set; }
        public string SenderAddressTown { get; set; }
        public string SenderAddressTownPostalCode { get; set; }
        public string SenderMobileNumber { get; set; }
        public string SenderElectronicMailAddress { get; set; }
    }
}
