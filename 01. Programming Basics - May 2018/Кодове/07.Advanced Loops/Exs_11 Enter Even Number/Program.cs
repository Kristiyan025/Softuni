using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int number;
            while (!(int.TryParse(input, out number)))
            {
                Console.WriteLine("Invalid number");
                input = Console.ReadLine();
                int.TryParse(input, out number);
            }
            while (number % 2 != 0)
            {
                input = Console.ReadLine();
                while (!(int.TryParse(input, out number)))
                {
                    Console.WriteLine("Invalid number");
                    input = Console.ReadLine();
                    int.TryParse(input, out number);
                }
            }
            Console.WriteLine(number);

        }
    }
}
