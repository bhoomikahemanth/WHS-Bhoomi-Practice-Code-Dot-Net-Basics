using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSDNPolymosphism
{
    class Man : Animal
    {
        // use the override keyword in the Derived/Child Class to override the Base/Parent class methods
        public override void sound()
        {
            Console.WriteLine("Man Sound.");
        }

    }
}
