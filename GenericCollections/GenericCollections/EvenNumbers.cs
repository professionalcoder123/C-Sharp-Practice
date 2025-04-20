using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class EvenNumbers
    {
        public static void DisplayEvenNumbers()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the number of elements to be added in the list");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            Console.WriteLine("Even numbers from list :");
            var evenNumbers = list.Where(n => n % 2 == 0).ToList();
            foreach(int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}