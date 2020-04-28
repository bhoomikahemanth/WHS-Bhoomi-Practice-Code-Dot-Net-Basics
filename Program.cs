using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharpDotnet2
{
    // Main Program
    class Program
    {
        // Main Method
        // Program Execution starts from here
        static void Main(string[] args)
        {
            //Create only the Objects of Child Classes to call/use Base(Parent) Class memebers

            // Car Object
            Car c = new Car();
            c.noWheels = 4;
            Console.WriteLine("Please enter the no of passengers for Car Object.");
            c.noPassengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Car Object : Inherited from Parent Class Vehicle. " + c.noPassengers);
            c.sound(c.noWheels);
            Console.WriteLine("Car Derived/Child Class Variable is => " + c.carBattery + "\n");

            // Bus object
            Bus b = new Bus();
            b.noWheels = 6;
            Console.WriteLine("Please enter the no of passengers for Bus Object.");
            b.noPassengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bus Object : Inherited from Parent Class Vehicle. " + b.noPassengers);
            b.sound(b.noWheels);
            Console.WriteLine("Bus Derived/Child Class Variable is => " + b.busConductor);

            // Program Exiting
            Console.ReadLine();
            Console.WriteLine("Press any key to continue.");

        }
    }
}
