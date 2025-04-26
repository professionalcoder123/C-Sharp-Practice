using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class NewFileText
    {
        public static void WriteFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyFile.txt";
            using(StreamWriter writer=new StreamWriter(path))
            {
                writer.WriteLine("Hello! This is my new file!");
            }
            Console.WriteLine("File created and text written successfully!");
        }
    }
}
