using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = int.Parse(Console.ReadLine());
            string[] arr = { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (index >= 1 && index <= 7)
            {
                Console.WriteLine(arr[index]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
