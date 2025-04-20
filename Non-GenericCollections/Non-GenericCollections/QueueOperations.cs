using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollections
{
    internal class QueueOperations
    {
        public static void PerformOperations()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(12.5f);
            queue.Enqueue(32.9);
            queue.Enqueue("Aditya");
            queue.Enqueue(true);

            int count = queue.Count;
            Console.WriteLine("Dequeued elements :");
            for(int i = 0; i < count; i++)
            {
                var element = queue.Dequeue();
                Console.Write(element+" ");
            }
        }
    }
}