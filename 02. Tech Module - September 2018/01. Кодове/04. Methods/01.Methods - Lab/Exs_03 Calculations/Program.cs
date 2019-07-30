using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Calculations
{
    class Program
    {
        static void Add(int firstNumber, int secondNumber)
        {

            Console.WriteLine(firstNumber + secondNumber);

        }
        static void Substract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
        static void Main(string[] args)
        {

            string oparation = Console.ReadLine().ToLower();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            switch (oparation)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "substract":
                    Substract(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }

        }
    }
}
