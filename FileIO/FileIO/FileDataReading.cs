using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileDataReading
    {
        public static void ReadDataFromFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyFile.txt";
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("File content :");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}
