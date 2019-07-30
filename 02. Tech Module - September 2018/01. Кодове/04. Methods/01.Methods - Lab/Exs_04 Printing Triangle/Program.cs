using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Printing_Triangle
{
    class Program
    {
        static void PrintingTriangle(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);

        }
    }
}
