using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new Dictionary<string, decimal[]>();
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "buy")
                {
                    break;
                }
                string[] info = product.Split(' ');
                string name = info[0];
                decimal price = decimal.Parse(info[1]);
                int count = int.Parse(info[2]);
                decimal[] productsInfo = new decimal[2];
                productsInfo[0] = price;
                productsInfo[1] = count;
                if (products.ContainsKey(name))
                {
                    products[name][0] = price;
                    products[name][1] += count;
                }
                else
                {
                    products.Add(name, productsInfo);
                }
            }
            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.Key} -> {(prod.Value[0] * prod.Value[1]):F2}");
            }

        }
    }
}
