using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {

            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Math.Round(bgn);
            Console.WriteLine(bgn.ToString() + " BGN");

        }
    }
}
