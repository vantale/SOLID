using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.CyclomaticComplexity.Switch
{
    internal class PaymentTransfer
    {
        public void Execute(string paymentType) {

            Console.WriteLine(Do(paymentType));
        }
        public static string Do(string paymentType)
        {
            switch (paymentType)
            {
                case "Domestic":
                    return "Sending Domestic Payment";

                case "Foreign":
                    return "Sending Foreign Payment";

                case "ZUS":
                    return "Sending ZUS Payment";

                case "US":
                    return "Sending US Payment";

                case "VAT7":
                    return "Sending VAT7 Payment";

                default: throw new InvalidDataException();
            }
        }
    }
}
