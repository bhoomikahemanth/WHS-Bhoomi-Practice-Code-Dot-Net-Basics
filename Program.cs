using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBNTest
{
    class Program
    {
        static void Main(string[] args)
        {

            InterfaceTestClass i = new InterfaceTestClass();

            i.interface1Method();
            i.interface2Method();

            Console.ReadKey();

        }
    }
}
