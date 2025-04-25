using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Publisher
    {
        public static event Action OnDataReceived;

        public void ReceiveData()
        {
            Console.WriteLine("Publisher : Data received!");
            OnDataReceived?.Invoke();
        }
    }

    internal class Subscriber
    {
        public void Subscribe()
        {
            Publisher.OnDataReceived += HandleDataReceived;
        }

        public void HandleDataReceived()
        {
            Console.WriteLine("Subscriber : Data received event handled!");
        }
    }
}