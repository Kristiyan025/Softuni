using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double obshto = (48.00 - h) * 0.75 + +h + p * 2.0 / 3.0;
            if (a == "leap") { obshto *= 23.0; obshto /= 20.0; }
            double result = Math.Truncate(obshto);
            Console.WriteLine(result);

        }
    }
}
