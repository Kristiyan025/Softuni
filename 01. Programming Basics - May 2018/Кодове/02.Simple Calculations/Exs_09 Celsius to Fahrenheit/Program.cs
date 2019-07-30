using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {

            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine(f);

        }
    }
}
