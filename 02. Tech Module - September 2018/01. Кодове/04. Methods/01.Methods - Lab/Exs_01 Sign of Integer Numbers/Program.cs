using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Sign_of_Integer_Numbers
{
    class Program
    {
        static void SignOfIntegrer(int number)
        {

            if (number > 0)
            {
                Console.WriteLine($"The number {number} is postive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }

        }
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            SignOfIntegrer(number);

        }
    }
}
