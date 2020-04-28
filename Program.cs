using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    // declare & define an enum inside or ouside a class
    enum level
    {
        // enum enum_name followed by enum items separated by ,
        // starts with 0
        low,
        medium,
        high
    }

    enum week
    {
        Sunday = 10,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an enum variable
            level l1 = level.low;
            Console.WriteLine("First Enum Leve : {0}",l1);

            level l2 = level.medium;
            Console.WriteLine("Second Enum Leve : {0}", l2);

            level l3 = level.high;
            Console.WriteLine("Third Enum Leve : {0}", l3);

            Console.WriteLine("\n");

            // An explicit type cast is required to convert an integral values : to get an int value from enum

            int i1 = (int) level.low;
            Console.WriteLine("First Enum Leve : {0}" + " at {1} ", l1,i1);

            int i2 = (int)level.medium;
            Console.WriteLine("First Enum Leve : {0}" + " at {1} ", l2, i2);

            int i3 = (int)level.high;
            Console.WriteLine("First Enum Leve : {0}" + " at {1} ", l3, i3);

            Console.WriteLine("\n");

            // Enum 2 Ex => can change the value of item & it updates automatically

            Console.WriteLine(week.Sunday);
            Console.WriteLine((int)week.Sunday);

            Console.WriteLine(week.Monday);
            Console.WriteLine((int)week.Monday);

            Console.WriteLine(week.Tuesday);
            Console.WriteLine((int)week.Tuesday);

            Console.WriteLine(week.Wednesday);
            Console.WriteLine((int)week.Wednesday);

            Console.WriteLine(week.Thursday);
            Console.WriteLine((int)week.Thursday);

            Console.WriteLine(week.Friday);
            Console.WriteLine((int)week.Friday);

            Console.WriteLine(week.Saturday);
            Console.WriteLine((int)week.Saturday);

            Console.ReadKey();

        }
    }
}
