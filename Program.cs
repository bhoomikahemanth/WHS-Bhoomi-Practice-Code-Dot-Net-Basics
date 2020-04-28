using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string fName = "Bhoomika";
            string lName = "Nagaraja";

            // String Interpolation => right way of string concatenation (+)
            string fullName = $"My Full Name is {fName} {lName}.";
            Console.WriteLine(fullName);

            // to include all character in a string literal
            String str1 = @"New Line \";
            Console.WriteLine(str1);

            try
            {
                // If we dont use @ => \ expexts us to specify a character to interpret
                String str2 = "Escape Character on console \"";
                Console.WriteLine(str2);
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // DateTime object of struct
            // Returns Default Value of Date & Time
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            // SET THE DATE & TIME
            DateTime crDate = new DateTime(2020,03,30);
            Console.WriteLine(crDate);

            DateTime crDt = DateTime.Now;
            Console.WriteLine(crDt);

            DateTime tdDt = DateTime.Today;
            Console.WriteLine(tdDt);

            Console.ReadKey();
        }
    }
}
