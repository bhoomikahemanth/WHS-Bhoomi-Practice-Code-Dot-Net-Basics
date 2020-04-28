using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSDNFuncOverLoad
{
    class MathOperation
    {

        public int Add(int a, int b)
        {
            Console.WriteLine("Add Method with 2 int parameters.");
            return a + b;
                        
        }

        public int Add(int a, int b, int c)
        {
            Console.WriteLine("Add Method with 3 int parameters.");
            return a + b + c;
        }

        public double Add(double a, double b, double c, double d)
        {
            Console.WriteLine("Add Method with 4 double parameters.");
            return a + b + c + d;
        }

    }
}
