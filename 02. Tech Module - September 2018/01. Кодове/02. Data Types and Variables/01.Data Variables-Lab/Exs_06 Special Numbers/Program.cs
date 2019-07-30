using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int digit = 0;
                int currentNumber = i;
                do
                {
                    digit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += digit;
                }
                while (currentNumber > 0);
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
