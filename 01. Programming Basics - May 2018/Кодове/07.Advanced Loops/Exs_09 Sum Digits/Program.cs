using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += (a % 10);
            do
            {
                a /= 10;
                sum += (a % 10);

            } while (a != 0);
            Console.WriteLine(sum);

        }
    }
}
