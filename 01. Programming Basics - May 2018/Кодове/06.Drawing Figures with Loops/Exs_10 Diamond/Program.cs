using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int cherti = n / 2, red = cherti;
            if (n % 2 == 0)
            {
                cherti--;
            }
            else
            {
                red++;
            }
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < cherti; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*"); cherti--;
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-");
                }
                if ((n % 2 == 1) && (i != 0))
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                }
                else if ((n % 2 == 0) && (i != 0))
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("-");
                    }
                }
                if (n % 2 == 0) Console.Write("*");
                for (int j = 0; j < cherti + 1; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            cherti = n / 2;
            if (n % 2 == 0)
            {
                cherti -= 2;
            }
            else
            {
                red--;
                cherti--;
            }
            for (int i = 1; i < n - red; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int j = 0; j < cherti; j++)
                {
                    Console.Write("-");
                }
                cherti--;

                if (n % 2 == 0)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j < cherti - 1; j++)
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cherti + 1; j++)
                        {
                            Console.Write("-");
                        }
                    }
                    for (int j = 0; j < cherti; j++)
                    {
                        Console.Write("-");
                    }
                    if (i == 1) Console.Write("-");
                    Console.Write("*");
                }
                if (n % 2 == 1)
                {
                    for (int j = 0; j < cherti; j++)
                    {
                        Console.Write("-");
                    }
                    if (i != n - red - 1)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("-");
                    }
                }
                else if ((n % 2 == 0) && (i != 0))
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
