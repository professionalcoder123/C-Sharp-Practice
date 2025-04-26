using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileCopying
    {
        public static void CopyContentsToAnotherFile()
        {
            string source = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyFile.txt";
            string destination = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\MyNewFile.txt";
            if (File.Exists(source))
            {
                using(StreamReader reader=new StreamReader(source))
                using(StreamWriter writer=new StreamWriter(destination))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("File copied successfully!");
            }
            else
            {
                Console.WriteLine("Source file does not exist!");
            }
        }
    }
}