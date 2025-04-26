using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileDeletion
    {
        public static void DeleteFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyFile.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted successfully!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}
