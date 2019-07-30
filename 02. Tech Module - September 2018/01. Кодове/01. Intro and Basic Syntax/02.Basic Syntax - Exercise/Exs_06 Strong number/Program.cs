using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine()), number1 = number;
            int digit;
            int sum = 0;
            int fact = 1;
            do
            {
                fact = 1;
                digit = number % 10;
                number = number / 10;
                for (int i = 2; i <= digit; i++)
                {
                    fact *= i;
                }
                sum += fact;
            }
            while (number != 0);
            if (number1 == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
