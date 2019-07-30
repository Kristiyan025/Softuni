using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_12_Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            if (a <= 10)
            {
                Console.WriteLine("slow");
            }
            else if ((a > 10) && (a <= 50))
            {
                Console.WriteLine("average");
            }
            else if ((a > 50) && (a <= 150))
            {
                Console.WriteLine("fast");
            }
            else if ((a > 150) && (a <= 1000))
            {
                Console.WriteLine("ultra fast");
            }
            else if (a > 1000)
            {
                Console.WriteLine("extremely fast");
            }

        }
    }
}
