using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class BrowserUrls
    {
        public static void DisplayBrowserUrls()
        {
            Stack<string> urls = new Stack<string>();
            Console.WriteLine("Enter the number of URLs you want");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the URL");
                string url = Console.ReadLine();
                urls.Push(url);
            }
            Console.WriteLine();
            Console.WriteLine("Popped URLs :");
            for(int i = 0; i < n; i++)
            {
                string url = urls.Pop();
                Console.WriteLine(url);
            } 
        }
    }
}