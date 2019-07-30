using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price;
            switch (s)
            {
                case "premiere":
                    price = 12.00; price *= r; price *= c;
                    break;
                case "normal":
                    price = 7.50; price *= r; price *= c;
                    break;
                case "discount":
                    price = 5.00; price *= r; price *= c;
                    break;
                default:
                    price = r * c;
                    break;
            }
            Console.WriteLine(price.ToString("0.00") + " leva");

        }
    }
}
