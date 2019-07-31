using System;
using System.Collections.Generic;

namespace Exs_03_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }
                var props = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = props[0];
                string product = props[1];
                double price = double.Parse(props[2]);
                if (!data.ContainsKey(shop))
                {
                    data.Add(shop, new Dictionary<string, double>());
                    data[shop].Add(product, price);
                }
                else
                {
                    data[shop].Add(product, price);
                }
            }
            foreach (var shop in data)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
