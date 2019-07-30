using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x1 < x2 && x >= x1 && x <= x2)
            {
                if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Inside");

                }
                else Console.WriteLine("Outside");
            }
            else if (x2 < x1 && x >= x2 && x <= x1)
            {
                if (y >= y2 && y <= y1)
                {
                    Console.WriteLine("Inside");

                }
                else Console.WriteLine("Outside");
            }

        }
    }
}
