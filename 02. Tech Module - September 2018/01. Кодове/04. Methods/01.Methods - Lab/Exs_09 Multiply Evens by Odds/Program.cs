using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Multiply_Evens_by_Odds
{
    class Program
    {
        static int CountDigits(double number)
        {
            string numberToString = number.ToString("0");
            int length = numberToString.Length;
            return length;
        }
        static int SumOfOddDigit(double number)
        {

            int sum = 0;
            int length = CountDigits(number);
            for (int i = 1; i <= length; i++)
            {
                double currentDigit = (number % Math.Pow(10, i)) / Math.Pow(10, i - 1);
                currentDigit = Math.Floor(currentDigit);
                int digit = Convert.ToInt32(currentDigit);
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
            }
            return sum;

        }
        static int SumOfEvenDigit(double number)
        {

            int sum = 0;
            int length = CountDigits(number);
            for (int i = 1; i <= length; i++)
            {
                double currentDigit = (number % Math.Pow(10, i)) / Math.Pow(10, i - 1);
                currentDigit = Math.Floor(currentDigit);
                int digit = Convert.ToInt32(currentDigit);
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;

        }
        static int Multiply(double number)
        {

            int oddSum = SumOfOddDigit(number);
            int evenSum = SumOfEvenDigit(number);
            return oddSum * evenSum;

        }
        static void Main(string[] args)
        {

            double number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(Multiply(number));

        }
    }
}
