using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.DataClumps
{
    internal class Counterparty
    {
        public string CounterpartyFirstName { get; set; }
        public string CounterpartyLastName { get; set; }
        public string CounterpartyStreet { get; set; }
        public string CounterpartyCity { get; set; }
        public string CounterpartyPostalCode { get; set; }
        public string CounterpartyPhoneNumber { get; set; }
        public string CounterpartyEmail { get; set; }
    }
}
