using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // try block : actual function/code of program
            try
            {
                int[] nos = { 1, 2, 3, 4, 5 };
                Console.WriteLine(nos[10]);
            }
            // catch block : to catch & display the errors
            catch(Exception e)
            {
                Console.WriteLine("Trying to print a value not defined.");
                Console.WriteLine(e.Message);
            }
            // finally block to exceute the block of code irrespective of try & catch
            finally
            {
                Console.WriteLine("Finall Block Executed!");
            }

            Console.ReadKey();

        }
    }
}
