using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Smallest_of_Three_Numbers
{
    class Program
    {
        static int Min(int num1, int num2, int num3)
        {
            int temp = num1;
            if (num1 < num2 && num1 < num3)
            {
                temp = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                temp = num2;
            }
            else
            {
                temp = num3;
            }            
            return temp;
        }
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Min(num1, num2, num3));

        }
    }
}
