using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // File Class => System.IO
            // File Methods

            // store in a variable & pass it to the File Method
            string writeTextString = "Hello, World!";

            // path & string
            File.WriteAllText("filename.txt", writeTextString);

            string readTextstring = File.ReadAllText("filename.txt");
            Console.WriteLine(readTextstring);

            Console.ReadKey();

        }
    }
}
