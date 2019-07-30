using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte n = sbyte.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);

        }
    }
}
