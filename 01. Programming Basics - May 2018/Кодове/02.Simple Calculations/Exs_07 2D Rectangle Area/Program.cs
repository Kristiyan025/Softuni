using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double p = 2 * Math.Abs(x2 - x1) + 2 * Math.Abs(y2 - y1);
            double a = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            Console.WriteLine(a);
            Console.WriteLine(p);

        }
    }
}
