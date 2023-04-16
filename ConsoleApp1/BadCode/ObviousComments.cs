using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BadCode
{
    public class ObviousComments
    {
        /*
        public void Execute()
        {
            int sum = 0; 

            for(int i = 0; i < 10; i++)
            {
                sum = CalculateValue(); // TODO: NB4-2188 "Incorrect value is returned aleatorily"
            }
        }
        */

        private int CalculateValue()
        {
            throw new NotImplementedException();
        }

    }
}
