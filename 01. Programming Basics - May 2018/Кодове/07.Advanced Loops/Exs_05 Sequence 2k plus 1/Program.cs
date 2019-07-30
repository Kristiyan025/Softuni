using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Sequence_2k_plus_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int p = 1;
            while (p <= a)
            {
                Console.WriteLine(p);
                p = p * 2 + 1;
            }

        }
    }
}
