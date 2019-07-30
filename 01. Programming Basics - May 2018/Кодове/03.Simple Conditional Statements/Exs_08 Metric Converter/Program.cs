using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            1 m = 1000 mm
            1 m = 100 cm
            1 m = 0.000621371192 mi
            1 m = 39.3700787 in
            1 m = 0.001 km
            1 m = 3.2808399 ft
            1 m = 1.0936133 yd
            */
            double size = double.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToLower();
            string output = Console.ReadLine().ToLower();
            double sz2 = size;
            if (input == "mm")
            {
                sz2 /= 1000;
            }
            else if (input == "cm")
            {
                sz2 /= 100;
            }
            else if (input == "mi")
            {
                sz2 /= 0.000621371192;
            }
            else if (input == "in")
            {
                sz2 /= 39.3700787;
            }
            else if (input == "km")
            {
                sz2 /= 0.001;
            }
            else if (input == "ft")
            {
                sz2 /= 3.2808399;
            }
            else if (input == "yd")
            {
                sz2 /= 1.0936133;
            }

            if (output == "mm")
            {
                sz2 *= 1000;
            }
            else if (output == "cm")
            {
                sz2 *= 100;
            }
            else if (output == "mi")
            {
                sz2 *= 0.000621371192;
            }
            else if (output == "in")
            {
                sz2 *= 39.3700787;
            }
            else if (output == "km")
            {
                sz2 *= 0.001;
            }
            else if (output == "ft")
            {
                sz2 *= 3.2808399;
            }
            else if (output == "yd")
            {
                sz2 *= 1.0936133;
            }
            Console.WriteLine(sz2.ToString("0.00000000"));

        }
    }
}
