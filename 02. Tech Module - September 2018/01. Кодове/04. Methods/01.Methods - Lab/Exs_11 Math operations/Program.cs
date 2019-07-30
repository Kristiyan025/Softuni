using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Math_operations
{
    class Program
    {
        static int Calculate(int firstNumber, char oparation, int secondNumber)
        {
            int izraz = 0;
            switch (oparation)
            {
                case '+':
                    izraz = firstNumber + secondNumber;
                    break;
                case '-':
                    izraz = firstNumber - secondNumber;
                    break;
                case '*':
                    izraz = firstNumber * secondNumber;
                    break;
                case '/':
                    izraz = firstNumber / secondNumber;
                    break;
            }
            return izraz;
        }
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            char oparation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNumber, oparation, secondNumber));

        }
    }
}
