using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_13_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            string kind = Console.ReadLine();
            double area;
            if (kind == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (kind == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (kind == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (kind == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
                Console.WriteLine(area.ToString("0.000"));
            }

        }
    }
}
