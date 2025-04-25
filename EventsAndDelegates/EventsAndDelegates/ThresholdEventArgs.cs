using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class ThresholdEventArgs : EventArgs
    {
        public int Value { get; set; }

        public ThresholdEventArgs(int value)
        {
            Value = value;
        }
    }

    internal class ThresholdChecker
    {
        public event EventHandler<ThresholdEventArgs> ThresholdExceeded;

        public void Check(int number)
        {
            if (number > 100)
            {
                ThresholdExceeded?.Invoke(this, new ThresholdEventArgs(number));
            }
            else
            {
                Console.WriteLine("Number is not greater than 100!");
            }
        }
    }

    internal class Logger
    {
        public void OnThresholdExceeded(object sender, ThresholdEventArgs e)
        {
            Console.WriteLine($"Logger : Threshold exceeded with value {e.Value}");
        }
    }
}