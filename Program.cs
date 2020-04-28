using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace DocConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" File Conversion from .doc to .docx \n");
            Word._Application app = new Word.Application();

            object fileFormat = Word.WdSaveFormat.wdFormatDocumentDefault;

            DirectoryInfo dir = new DirectoryInfo(@"C:\Application\DocToDocxConvert");
           // try
            //{

                foreach (FileInfo file in dir.GetFiles("*.doc", SearchOption.AllDirectories))
                {
                    
                    Console.WriteLine("The File Extenions for  " + file.FullName + "  =>  " + file.Extension + "\n");

                    //object filename = file.Extension.Replace(".DOC", ".doc");
                    
                    //Console.WriteLine("After Replace the File Extenions for  " + file.FullName + "  =>  " + file.Extension + "\n");

                    if (file.Extension == ".DOC")
                    {
                        Console.WriteLine("These are the Files with => " + file.Extension);

                        object filename = file.FullName;
                        object newfilename = file.FullName.Replace(".DOC", ".docx");
                        Word._Document doc = app.Documents.Open(filename);

                        doc.Convert();
                        doc.SaveAs(newfilename, fileFormat);
                        Console.WriteLine("These are the Files with converted to => " + newfilename +"\n");
                        doc.Close();
                        doc = null;
                        file.Delete();                        
                    }
                    else if (file.Extension == ".doc")
                    {
                        Console.WriteLine("These are the Files with => " + file.Extension);

                        object filename = file.FullName;
                        object newfilename = file.FullName.Replace(".doc", ".docx");
                        Word._Document doc = app.Documents.Open(filename);

                        doc.Convert();
                        doc.SaveAs(newfilename, fileFormat);
                        Console.WriteLine("These are the Files with converted to => " + newfilename + "\n");
                        doc.Close();
                        doc = null;
                        file.Delete();                        
                    }
                }
                app.Quit();
                app = null;

                Console.WriteLine("File Conversion Completed! \n");
                Console.WriteLine("Press any key to continue. \n");
                Console.ReadLine();
            //}

            /*catch(System.Runtime.InteropServices.COMException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }       
    }
}
