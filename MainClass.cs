using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNTest1
{

    class MainClass
    {
        private static string stVar = "Static Variable";
        private string nonStVar = "Non-Static Variable"; // non-static
        private string color3;
        private string color4;

        static void myStaictFunc1()
        {
            Console.WriteLine(" I am in myFunc1 method. static method => no object to invoke.\n");
        }

        void myFunc2()
        {
            Console.WriteLine(" I am in non-static myFunc2 method. Invoked by object.\n");
        }

        public MainClass()
        {
            color3 = "black";
        }
        public MainClass(string color)
        {
            color4 = color;
        }
            
        // Method Over-loading
        private int plusMethod( int a, int b)
        {
            int c = a + b;
            return c;
        }

        private long plusMethod(long a, long b)
        {
            long c = a + b;
            return c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Static variable => " + stVar + "\n"); // no object required to access the variable

            // static method call
            myStaictFunc1();

            // object for members variables or attributes or fields & methods or functions
            MainClass pobj = new MainClass();

            Console.WriteLine("Non-Static variable => " + pobj.nonStVar + "\n");

            // object for parameterised constructor
            MainClass pobjc = new MainClass("white"); 

            // non-static method call
            pobj.myFunc2();

            Console.WriteLine("Default Constructor object variable : " +pobj.color3 + "\n");

            Console.WriteLine("Parameterised Constructor object variable : " + pobjc.color4 + "\n");

            // Class1 private variable => not accessible in here.

            // object of Class1 to access its variables
            Class1 c1 = new Class1();

            Console.WriteLine("Class1 private variable not accessible => " +  "c1.prVar" + "\n");

            Console.WriteLine("Class1 public variable accessible => " + c1.pubVar + "\n");

            c1.PrVar = "Class-1 Private Variable";
            Console.WriteLine("Class1 private variable not accessible but can be accessed via Property => " + c1.PrVar + "\n");

            // Marks the end of Program!
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine(); // to halt the console window to see the output            
        }
    }
}
