using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 0; i <= a; i += 2)
            {
                Console.WriteLine(p);
                p = p * 4;
            }

        }
    }
}
