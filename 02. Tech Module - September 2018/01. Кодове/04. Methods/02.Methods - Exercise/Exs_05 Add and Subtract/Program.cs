using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(Sum(firstNumber,secondNumber),thirdNumber));

        }

        static int Sum(int f, int s)
        {
            return f + s;
        }
        static int Substract(int sum, int t)
        {
            return sum - t;
        }

    }
}
