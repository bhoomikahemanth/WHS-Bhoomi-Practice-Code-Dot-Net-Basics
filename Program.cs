using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    // A Struct can be inside or outside a C# Class
    
    class Program
    {
        // struct 
        struct Emp
        {
            // struct members
            public int id;
            public char initial;
            public string fName;
            public string lName;

            // struct property
            public string address { get; set; }

            // static constructor
            static Emp()
            {
                Console.WriteLine("Static Constructor.");
            }

            // parameterized constructor for struct "Emp"
            public Emp(int Id, char Initial, string FName, string LName, string address)
            {
                id = Id;
                initial = Initial;
                fName = FName;
                lName = LName;
                this.address = address;

            }

        }
        static void Main(string[] args)
        {
            // struct object
            Emp e1 = new Emp();

            // accessing & printing off the struct members
            Console.WriteLine(e1.id);
            Console.WriteLine(e1.initial);
            Console.WriteLine(e1.fName);
            Console.WriteLine(e1.lName);
            Console.WriteLine(e1.address);

            Emp e2 = new Emp(1,'N',"Bhoomika","Nagaraja","Bhoomi Address");
            Console.WriteLine(e2.id);
            Console.WriteLine(e2.initial);
            Console.WriteLine(e2.fName);
            Console.WriteLine(e2.lName);
            Console.WriteLine(e2.address);

            // struct object without new keyword => initilize & then use
            // which disables the use of methods, properties & events etc...
            Emp Emp;

            // Initialize & use all the struct members
            Emp.id = 2;
            Console.WriteLine(Emp.id);
            Emp.initial = 'J';
            Console.WriteLine(Emp.initial);
            Emp.fName = "Hemanth";
            Console.WriteLine(Emp.fName);
            Emp.lName = "Jagadish";
            Console.WriteLine(Emp.lName);
            // Emp.address = "Hem Address";
            // Console.WriteLine(Emp.address);
            
            Console.ReadKey();

        }
    }
}
