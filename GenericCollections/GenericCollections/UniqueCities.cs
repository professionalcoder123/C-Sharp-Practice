using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class UniqueCities
    {
        public static void PrintCities()
        {
            HashSet<string> cities = new HashSet<string>();
            Console.WriteLine("Enter the number of cities");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the city");
                string city = Console.ReadLine();
                if (!cities.Contains(city))
                {
                    cities.Add(city);
                }
            }
            Console.WriteLine("Unique cities :");
            foreach(string city in cities)
            {
                Console.Write(city + " ");
            }
        }
    }
}