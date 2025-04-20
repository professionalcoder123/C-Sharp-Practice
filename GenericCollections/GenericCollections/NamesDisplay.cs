using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class NamesDisplay
    {
        public static void PrintNames()
        {
            List<string> nameList = new List<string>();
            Console.WriteLine("Enter the number of elements to be added in the list");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                string name = Console.ReadLine();
                nameList.Add(name);
            }
            var names = nameList.Where(n => n.StartsWith('A')).ToList();
            Console.WriteLine("Names starting with 'A' :");
            foreach(string name in names)
            {
                Console.Write(name + " ");
            }
        }
    }
}