using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharpDotnet2
{
    class Vehicle
    {

        // inheritable variables/fields/attributes
        public int noWheels;
        public int noPassengers;

        // inheritable functions/methods
        public void sound(int wheenlNo)
        {
            if (wheenlNo == 4)
            {
                Console.WriteLine("Car Sound.");
            }
            else if (wheenlNo == 6)
            {
                Console.WriteLine("Bus Sound.");
            }
            else
            {
                Console.WriteLine("Please input the correct wheel number.");
            }
            
        }

    }
}
