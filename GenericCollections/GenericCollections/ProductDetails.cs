using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class ProductDetails
    {
        public static void SortProductsById()
        {
            SortedDictionary<int, string> products = new SortedDictionary<int, string>();
            Console.WriteLine("Enter the number of key-value pairs to be added");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the product ID");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the product");
                string name = Console.ReadLine();
                products.Add(id, name);
            }
            Console.WriteLine();
            Console.WriteLine("Product details :");
            foreach(var product in products)
            {
                Console.Write($"Product ID : {product.Key}, Product Name : {product.Value}");
                Console.WriteLine();
            }
        }
    }
}