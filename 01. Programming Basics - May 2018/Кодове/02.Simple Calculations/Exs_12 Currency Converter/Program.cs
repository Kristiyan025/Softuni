using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_12_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              BGN  USD      EUR      GBP
              1    1.79549  1.95583  2.53405
            */
            double size = double.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToUpper();
            string output = Console.ReadLine().ToUpper();
            double sz2 = size;
            if (input == "USD")
            { sz2 /= 1.79549; }
            else if (input == "EUR")
            { sz2 /= 1.95583; }
            else if (input == "GBP")
            { sz2 /= 2.53405; }

            if (output == "USD")
            { sz2 *= 1.79549; }
            else if (output == "EUR")
            { sz2 *= 1.95583; }
            else if (output == "GBP")
            { sz2 *= 2.53405; }
            Console.WriteLine(sz2.ToString("0.00"));

        }
    }
}
