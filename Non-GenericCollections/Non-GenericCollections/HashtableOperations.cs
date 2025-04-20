using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollections
{
    internal class HashtableOperations
    {
        public static void SearchByName()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Aditya", "9325127059");
            ht.Add("Sohel", "9508924800");
            ht.Add("Priyanka","8201883082");
            ht.Add("Manish", "9001830184");
            ht.Add("Hemant", "8562270849");
            Console.WriteLine("Enter the name to get his/her details");
            string name = Console.ReadLine();
            if (ht.ContainsKey(name))
            {
                Console.WriteLine($"Phone Number : {ht[name]}");
            }
            else
            {
                Console.WriteLine("Details not found!");
            }
        }
    }
}