using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());      
            int c = 1;
            for (int i = 2; i <= a; i++)
            {
                c *= i;
            }
            Console.WriteLine(c);

        }
    }
}
