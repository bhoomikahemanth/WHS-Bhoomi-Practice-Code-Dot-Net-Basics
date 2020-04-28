using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSDNPolymosphism
{
    class Animal
    {
        // use the virtual keyword in the Base/Parent Class to override the Base/Parent class method
        public virtual void sound()
        {
            Console.WriteLine("Animal Sound.");
        }

    }
}
