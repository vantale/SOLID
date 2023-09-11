using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells
{
    internal class CombinatoryExplosion
    {
        public int Multiply(int a, int b) => a * b;
        public float Multiply(float a, float b) => a * b;
        public double Multiply (double a, double b) => a * b;
        public decimal Multiply(decimal a, decimal b) => a * b;



        public T Multiply<T>(T a, T b) {

            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

    }

    
}
