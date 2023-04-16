using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BadCode
{
    public class Intents
    {
        public static void Execute()
        {
        double sum = 0;
        for(int i = 0; i<100; i++)
        {
        sum = (sum + i + Math.Abs(i*2) - Math.Cos((double) i/2));
        }
        }
    }
}
