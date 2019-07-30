using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int p = 1;
            Console.WriteLine(p);
            for (int i = 1; i <= a; i++)
            {
                p = p * 2;
                Console.WriteLine(p);
            }

        }
    }
}
