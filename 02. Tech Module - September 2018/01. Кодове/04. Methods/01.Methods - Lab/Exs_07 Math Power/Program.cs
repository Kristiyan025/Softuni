using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Math_Power
{
    class Program
    {
        static double PoweredNumber(double number,double power)
        {
            
            return Math.Pow(number, power);

        }
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(PoweredNumber(number, power));

        }
    }
}
