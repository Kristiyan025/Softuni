using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Multiplication_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {start} = {number * start}");
                start++;
            }
            while (start <= 10);

        }
    }
}
