using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            if ((a >= 100 && a <= 200) || a == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
