using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            if (a == 1) Console.WriteLine("Monday");
            else if (a == 2) Console.WriteLine("Tuesday");
            else if (a == 3) Console.WriteLine("Wednesday");
            else if (a == 4) Console.WriteLine("Thursday");
            else if (a == 5) Console.WriteLine("Friday");
            else if (a == 6) Console.WriteLine("Saturday");
            else if (a == 7) Console.WriteLine("Sunday");
            else Console.WriteLine("Error");

        }
    }
}
