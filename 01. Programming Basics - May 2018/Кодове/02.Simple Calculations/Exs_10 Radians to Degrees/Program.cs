using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {

            double rad = double.Parse(Console.ReadLine());
            double deg = (180 / Math.PI) * rad;
            Math.Round(deg);
            Console.WriteLine(deg);

        }
    }
}
