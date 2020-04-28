using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDyPoly
{
    // Abstract Class has Abstract Methods
    // Abstract Class cannot be instantiated
    // Abstract Class should be inherited
    abstract class Animal
    {
        // Abstract Methods has no body or implementation
        // Abstract Methods shd be implemented in the derived class that inherits this abstarct base class
        public abstract void sound();

    }
}
