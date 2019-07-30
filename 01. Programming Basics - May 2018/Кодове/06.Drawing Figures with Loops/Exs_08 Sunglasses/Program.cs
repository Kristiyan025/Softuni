using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = n / 2;
            if (n % 2 == 1) p++;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 2; i <= (n - 1); i++)
            {
                Console.Write("*");
                for (int j = 0; j < (2 * n - 2); j++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if (i == p)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int j = 0; j < (2 * n - 2); j++)
                {
                    Console.Write("/");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
