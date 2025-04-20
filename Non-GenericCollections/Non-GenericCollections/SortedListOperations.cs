using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollections
{
    internal class SortedListOperations
    {
        public static void SortByRollNumber()
        {
            SortedList list = new SortedList();
            list.Add(10, "Aditya");
            list.Add(84, "Priyanka");
            list.Add(73, "Sohel");
            list.Add(30, "Kedar");
            list.Add(45, "Kalpesh");
            foreach(DictionaryEntry entry in list)
            {
                Console.Write($"Roll No. : {entry.Key}, Name : {entry.Value}");
                Console.WriteLine();
            }
        }
    }
}