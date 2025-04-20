using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class QueueOperations
    {
        public static void PerformOperations()
        {
            Queue<int> queue = new Queue<int>();
            int count = 10;
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter an element");
                int element = int.Parse(Console.ReadLine());
                queue.Enqueue(element);
            }
            for(int i = 0; i < 3; i++)
            {
                queue.Dequeue();
            }
            Console.WriteLine("Remaining elements :");
            foreach(int number in queue)
            {
                Console.Write(number + " ");
            }
        }
    }
}