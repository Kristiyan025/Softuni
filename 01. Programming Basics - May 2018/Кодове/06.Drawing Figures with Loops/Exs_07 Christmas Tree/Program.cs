using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < p; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");
                for (int j = 0; j < p; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                p++;
                Console.WriteLine();
            }

        }
    }
}
