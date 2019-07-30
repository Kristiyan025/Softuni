using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());
            double p = Math.PI * 2 * r;
            double a = Math.PI * r * r;
            Console.WriteLine("Area = " + a.ToString());
            Console.WriteLine("Perimeter = " + p.ToString());

        }
    }
}
