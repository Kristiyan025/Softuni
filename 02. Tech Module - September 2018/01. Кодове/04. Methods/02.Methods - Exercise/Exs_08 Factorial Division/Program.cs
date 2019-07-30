using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            decimal result = Division(firstNumber, secondNumber);
            Math.Round(result, 2);
            Console.WriteLine($"{result:F2}");

        }

        static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else if (num < 0)
            {
                return -1;
            }
            else return num * Factorial(num - 1);
        }
        static decimal Division(int fnum, int snum)
        {
            decimal d = Factorial(fnum) / Factorial(snum);
            return d;
        }
    }
}
