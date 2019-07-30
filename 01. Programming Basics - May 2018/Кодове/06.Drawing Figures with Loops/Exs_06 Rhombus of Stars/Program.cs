using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int p = 1; p <= i; p++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = (n - 1); i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int p = 1; p <= i; p++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
