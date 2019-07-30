using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string p = Console.ReadLine();
            string k = Console.ReadLine();
            while (k.Contains(p))
            {
                k = k.Replace(p, string.Empty);
            }
            Console.WriteLine(k);

        }
    }
}
