using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolyTest
{
    class Program
    {
        void print (int i)
        {
            Console.WriteLine("Printing int: "+i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing int: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing int: {0}", s);
        }

        static void Main(string[] args)
        {

            Program p = new Program();

            p.print(5);

            p.print(67.89);

            p.print("Hey!....");

            Console.ReadKey();
            
        }
    }
}
