using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDyPoly
{
    // Main Program Class
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {

            // Abstract (Base) Class has Abstract Methods
            // Abstract (Base) Class cannot be instantiated
            // Abstract (Base) Class should be inherited

            // Cat Derived Class object
            Cat b = new Cat();
            b.sound();

            // Dog Derived Class object
            Dog d = new Dog();
            d.sound();

            Console.ReadKey();

        }
    }
}
