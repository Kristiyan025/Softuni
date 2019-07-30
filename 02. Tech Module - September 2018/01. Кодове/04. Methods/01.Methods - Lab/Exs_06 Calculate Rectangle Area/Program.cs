using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Calculate_Rectangle_Area
{
    class Program
    {
        static int GetRectangleArea(int width,int height)
        {

            return width * height;

        }
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(width,height));

        }
    }
}
