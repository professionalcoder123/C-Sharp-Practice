using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void DelegateMessage();

    internal class MessageDisplay
    {
        public static void GiveMessage()
        {
            DelegateMessage msg = delegate ()
            {
                Console.WriteLine("Hello! I am inside the delegate.");
            };
            msg();
        }
    }
}