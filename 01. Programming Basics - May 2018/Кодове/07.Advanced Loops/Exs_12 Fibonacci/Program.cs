using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_12_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1) { Console.WriteLine(1); }
            else
            {
                int a0 = 1, a1 = 1, a2 = 2;
                for (int i = 2; i <= n; i++)
                {
                    a2 = a0 + a1;
                    a0 = a1;
                    a1 = a2;
                }
                Console.WriteLine(a2);
            }

        }
    }
}
