using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Orders
{
    class Program
    {
        static double OrderTotalPrice(string product,int quantity)
        {

            double singlePrice = 0;
            double totalPrice = 0;
            switch (product)
            {
                case "coffee":
                    singlePrice = 1.50;
                    break;
                case "water":
                    singlePrice = 1.00;
                    break;
                case "coke":
                    singlePrice = 1.40;
                    break;
                case "snacks":
                    singlePrice = 2.00;
                    break;
            }
            totalPrice = singlePrice * quantity;
            return totalPrice;

        }
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            short quantity = short.Parse(Console.ReadLine());            
            Console.WriteLine("{0:F2}", OrderTotalPrice(product, quantity));

        }
    }
}
