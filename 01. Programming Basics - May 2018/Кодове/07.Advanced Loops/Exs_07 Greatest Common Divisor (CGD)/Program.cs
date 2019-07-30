using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                int x = a;
                a = b;
                b = x;
            }
            int p;
            while (b != 0)
            {
                p = a % b;
                a = b;
                b = p;
            }
            Console.WriteLine(a);

        }
    }
}
