using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBNTest
{
    class InterfaceTestClass : Interface1, Interface2
    {
        public void interface1Method()
        {
            Console.WriteLine("Interface 1 Method.");
        }

        public void interface2Method()
        {
            Console.WriteLine("Interface 2 Method.");
        }
    }
}
