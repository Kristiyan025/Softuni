using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {

            int b = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("$ ");
                }
                p++;
                Console.WriteLine();

            }
        }
    }
}
