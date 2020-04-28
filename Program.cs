using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSDNFuncOverLoad
{
    class Program
    {
        static void Main(string[] args)
        {

            MathOperation mo = new MathOperation();

            int res1 = mo.Add(1, 2);
            Console.WriteLine(res1);

            int res2 = mo.Add(1, 2, 3);
            Console.WriteLine(res2);

            double res3 = mo.Add(1.2, 2.3, 3.4, 4.5);
            Console.WriteLine(res3);

            Console.WriteLine("Press any ket to continue.");
            Console.ReadLine();

        }
    }
}
