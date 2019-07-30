using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_15_Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            if ((a <= 100) && (a >= 0))
            {
                if (a % 10 != 0)
                {
                    if (a % 100 / 10 == 2)
                    {
                        Console.Write("twenty ");
                    }
                    else if (a % 100 / 10 == 3)
                    {
                        Console.Write("thirty ");
                    }
                    else if (a % 100 / 10 == 4)
                    {
                        Console.Write("forty ");
                    }
                    else if (a % 100 / 10 == 5)
                    {
                        Console.Write("fifty ");
                    }
                    else if (a % 100 / 10 == 6)
                    {
                        Console.Write("sixty ");
                    }
                    else if (a % 100 / 10 == 7)
                    {
                        Console.Write("seventy ");
                    }
                    else if (a % 100 / 10 == 8)
                    {
                        Console.Write("eighty ");
                    }
                    else if (a % 100 / 10 == 9)
                    {
                        Console.Write("ninety ");
                    }
                }
                else if (a % 10 == 0)
                {
                    if (a % 100 / 10 == 2)
                    {
                        Console.Write("twenty");
                    }
                    else if (a % 100 / 10 == 3)
                    {
                        Console.Write("thirty");
                    }
                    else if (a % 100 / 10 == 4)
                    {
                        Console.Write("forty");
                    }
                    else if (a % 100 / 10 == 5)
                    {
                        Console.Write("fifty");
                    }
                    else if (a % 100 / 10 == 6)
                    {
                        Console.Write("sixty");
                    }
                    else if (a % 100 / 10 == 7)
                    {
                        Console.Write("seventy");
                    }
                    else if (a % 100 / 10 == 8)
                    {
                        Console.Write("eighty");
                    }
                    else if (a % 100 / 10 == 9)
                    {
                        Console.Write("ninety");
                    }
                }
                if (a % 100 / 10 != 1)
                {
                    if (a % 10 == 1)
                    {
                        Console.Write("one");
                    }
                    if (a % 10 == 2)
                    {
                        Console.Write("two");
                    }
                    if (a % 10 == 3)
                    {
                        Console.Write("three");
                    }
                    if (a % 10 == 4)
                    {
                        Console.Write("four");
                    }
                    if (a % 10 == 5)
                    {
                        Console.Write("five");
                    }
                    if (a % 10 == 6)
                    {
                        Console.Write("six");
                    }
                    if (a % 10 == 7)
                    {
                        Console.Write("seven");
                    }
                    if (a % 10 == 8)
                    {
                        Console.Write("eight");
                    }
                    if (a % 10 == 9)
                    {
                        Console.Write("nine");
                    }
                }
                if (a % 100 / 10 == 1)
                {
                    if (a % 10 == 0)
                    {
                        Console.Write("ten");
                    }
                    if (a % 10 == 1)
                    {
                        Console.Write("eleven");
                    }
                    if (a % 10 == 2)
                    {
                        Console.Write("twelve");
                    }
                    if (a % 10 == 3)
                    {
                        Console.Write("thirteen");
                    }
                    if (a % 10 == 4)
                    {
                        Console.Write("fourteen");
                    }
                    if (a % 10 == 5)
                    {
                        Console.Write("fifteen");
                    }
                    if (a % 10 == 6)
                    {
                        Console.Write("sixteen");
                    }
                    if (a % 10 == 7)
                    {
                        Console.Write("seventeen");
                    }
                    if (a % 10 == 8)
                    {
                        Console.Write("eighteen");
                    }
                    if (a % 10 == 9)
                    {
                        Console.Write("nineteen");
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("zero");
                }
                if (a == 100)
                {
                    Console.WriteLine("one hundred");
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
