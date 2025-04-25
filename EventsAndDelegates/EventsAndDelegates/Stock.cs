using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Stock
    {
        public event Action<decimal> PriceChanged;

        public void UpdatePrice(decimal newPrice)
        {
            Console.WriteLine($"Stock : Price updated to {newPrice}");
            PriceChanged?.Invoke(newPrice);
        }
    }

    internal class EmailAlert
    {
        public void OnPriceChanged(decimal price)
        {
            Console.WriteLine($"Email Alert : New stock price is {price}");
        }
    }

    internal class SMSAlert
    {
        public void OnPriceChanged(decimal price)
        {
            Console.WriteLine($"SMS Alert : New stock price is {price}");
        }
    }
}