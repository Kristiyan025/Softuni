using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var pruduct = Console.ReadLine();
            var town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (pruduct == "beer")
                {
                    Console.WriteLine(count * 1.20);
                }
                if (pruduct == "water")
                {
                    Console.WriteLine(count * 0.80);
                }
                if (pruduct == "coffee")
                {
                    Console.WriteLine(count * 0.50);
                }
                if (pruduct == "sweets")
                {
                    Console.WriteLine(count * 1.45);
                }
                if (pruduct == "peanuts")
                {
                    Console.WriteLine(count * 1.60);
                }
            }
            else if (town == "Plovdiv")
            {
                if (pruduct == "beer")
                {
                    Console.WriteLine(count * 1.15);
                }
                if (pruduct == "water")
                {
                    Console.WriteLine(count * 0.70);
                }
                if (pruduct == "coffee")
                {
                    Console.WriteLine(count * 0.40);
                }
                if (pruduct == "sweets")
                {
                    Console.WriteLine(count * 1.30);
                }
                if (pruduct == "peanuts")
                {
                    Console.WriteLine(count * 1.50);
                }
            }
            else if (town == "Varna")
            {
                if (pruduct == "beer")
                {
                    Console.WriteLine(count * 1.10);
                }
                if (pruduct == "water")
                {
                    Console.WriteLine(count * 0.70);
                }
                if (pruduct == "coffee")
                {
                    Console.WriteLine(count * 0.45);
                }
                if (pruduct == "sweets")
                {
                    Console.WriteLine(count * 1.35);
                }
                if (pruduct == "peanuts")
                {
                    Console.WriteLine(count * 1.55);
                }
            }

        }
    }
}
