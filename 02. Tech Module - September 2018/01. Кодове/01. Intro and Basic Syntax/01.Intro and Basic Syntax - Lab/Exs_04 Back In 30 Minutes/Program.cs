using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 0001, hour, minute, 0);
            date = date.AddMinutes(30);
            Console.WriteLine($"{date.Hour}:{date.Minute:D2}");

        }
    }
}
