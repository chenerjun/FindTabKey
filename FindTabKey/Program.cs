using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTabKey
{
    class Program
    {
        static void Main(string[] args)
        {
   

            //CSV stored name
            Console.WriteLine("File name to be scanned (no extension): c:\\temp\\Err_sss.txt");
            string scanfile = Console.ReadLine();
            if (scanfile == "") scanfile = "c:\\temp\\sss.txt";


            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\temp\\err_sss.txt");  // open a file to log the result of scanning
            file.WriteLine(DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss")); // write scanning time
            file.WriteLine(scanfile); //write scanned file name
            file.WriteLine("");

            string log = "";
 

            try
            {

                int i = 0;
                var lines = File.ReadLines(scanfile);

                foreach (var line in lines)
                {
                    char[] subchars = line.ToCharArray();
                    //int errorchar = line.IndexOf(errorletter);
                    if (subchars[0] == '\t')
                    {
                        Console.WriteLine(" Find TAB at : "+i);  
                        log = "   Row#: " + i + " ;   ";
                        Console.WriteLine(log);
                        file.WriteLine(log);
                    }


                    i++;
                }

                file.Close();
                Console.WriteLine();
                Console.WriteLine("  " + DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss"));
                Console.Read();

            }
            catch (Exception e)
            {
                file.WriteLine("The file could not be read:");
                file.WriteLine(e.Message);
                file.WriteLine();
                file.Close();

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine("  " + DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss"));
                Console.Read();
            }


        }
    }
}
