using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollections
{
    internal class StackOperations
    {
        public static void PerformOperations()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(12.6);
            stack.Push(12.5f);
            stack.Push("Aditya");
            stack.Push(true);

            int count = stack.Count;
            Console.WriteLine("Popped elements :");
            for(int i = 0; i < count; i++)
            {
                var element = stack.Pop();
                Console.Write(element + " ");
            }
        }
    }
}