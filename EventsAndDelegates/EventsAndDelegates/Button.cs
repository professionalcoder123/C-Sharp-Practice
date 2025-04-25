using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Button
    {
        public event EventHandler Clicked;

        public void SimulateClick()
        {
            Console.WriteLine("Button clicked!");
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }

    internal class UIHandler
    {
        public void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("UI Handler : Button was clicked!");
        }
    }
}