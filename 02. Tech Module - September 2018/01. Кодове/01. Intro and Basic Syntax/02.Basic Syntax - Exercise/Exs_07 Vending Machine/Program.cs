using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            decimal cent;
            decimal sum = 0.0m;
            while (input != "Start")
            {
                cent = decimal.Parse(input);
                if (cent == 0.10m || cent == 0.20m || cent == 0.50m || cent == 1.00m || cent == 2.00m)
                {
                    sum += cent;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {cent}");
                }
                input = Console.ReadLine();
            }
            decimal price;
            bool istrue = false;
            string product = Console.ReadLine();
            while (product != "End")
            {
                price = 0.0m;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0m;
                        istrue = true;
                        break;
                    case "Water":
                        price = 0.7m;
                        istrue = true;
                        break;
                    case "Crisps":
                        price = 1.5m;
                        istrue = true;
                        break;
                    case "Soda":
                        price = 0.8m;
                        istrue = true;
                        break;
                    case "Coke":
                        price = 1.0m;
                        istrue = true;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        istrue = false;
                        break;
                }
                if (sum >= price && istrue)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");

        }
    }
}
