using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Number_in_Range__1_100_
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a number in the range [1...100]:");
                int a = int.Parse(Console.ReadLine());
                if ((a >= 1) && (a <= 100))
                {
                    Console.WriteLine("The number is:" + a.ToString());
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

        }
    }
}
