using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_House
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = n / 2;
            if (n % 2 == 1) p++;
            for (int i = 1; i <= p; i++)
            {
                for (int j = 0; j < (p - i); j++)
                {
                    Console.Write("-");
                }
                for (int t = 1; t <= i; t++)
                {
                    Console.Write("*");
                }
                for (int t = 1; t <= i; t++)
                {
                    if (t == i && n % 2 == 1) break;
                    else
                    {
                        Console.Write("*");
                    }
                }
                for (int j = 0; j < (p - i); j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < (n - p); i++)
            {
                Console.Write("|");
                for (int j = 0; j < (n - 2); j++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }

        }
    }
}
