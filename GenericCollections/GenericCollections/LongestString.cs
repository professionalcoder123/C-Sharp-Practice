using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class LongestString
    {
        public static void FindLongestString()
        {
            List<string> strings = new List<string>();
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();
                strings.Add(str);
            }
            var longestStrings = strings.Where(s => s.Length > 5);
            Console.WriteLine();
            Console.WriteLine("Strings of length greater than 5 :");
            foreach(string str in longestStrings)
            {
                Console.Write(str + " ");
            }
        }
    }
}