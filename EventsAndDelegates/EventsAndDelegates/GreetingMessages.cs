using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate string GreetMessage(string message);

    internal class GreetingMessages
    {
        public static string GreetHello(string msg)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            string message = msg + " " + name + "!";
            return message;
        }

        public static string GreetBye(string msg)
        {
            return msg;
        }
    }
}