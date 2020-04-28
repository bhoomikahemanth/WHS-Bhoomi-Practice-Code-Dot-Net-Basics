using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSDNPolymosphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //Objects of the Child/Derived Class are created

            Animal a = new Animal();
            a.sound();

            //Cat c = new Cat();
            Animal c = new Cat();
            c.sound();

            //Dog d = new Dog();
            Animal d = new Dog();
            d.sound();

            // Man n = new Man();
            Animal n = new Man();
            n.sound();

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
       
        }
    }
}
