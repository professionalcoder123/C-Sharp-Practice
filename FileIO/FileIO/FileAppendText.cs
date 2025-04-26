using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileAppendText
    {
        public static void AppendTextInFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyFile.txt";
            if (File.Exists(path))
            {
                File.AppendAllText(path, "\nI am using this file for implementing file handling topics.");
                Console.WriteLine("Text appended successfully!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}