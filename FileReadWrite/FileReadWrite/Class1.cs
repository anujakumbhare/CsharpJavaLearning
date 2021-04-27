using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    public static class FileReader
    {
        public static void ReadFile()
        {
            String line;
            StreamReader sr = new StreamReader("C:\\Users\\Anuja\\ConsoleApp\\ConsoleApp1\\ConsoleApp1\\SampleFile.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
           // Console.ReadLine();
            return;
        }

        public static void WriteToFile()
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Anuja\\ConsoleApp\\ConsoleApp1\\ConsoleApp1\\SampleFile1.txt");

             String line;
             StreamReader sr = new StreamReader("C:\\Users\\Anuja\\ConsoleApp\\ConsoleApp1\\ConsoleApp1\\SampleFile.txt");
             line = sr.ReadLine();
             while (line != null)
             {
                 Console.WriteLine(line);
                 sw.WriteLine(line + " Hello world");
                 line = sr.ReadLine();
             }
             sr.Close();
            //sw.WriteLine(" Hello world");
            sw.Close();
            return;
        }
    }
}
