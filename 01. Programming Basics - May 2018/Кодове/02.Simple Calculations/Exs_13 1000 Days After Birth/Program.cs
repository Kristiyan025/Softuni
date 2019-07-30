using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_13_1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy",
                  CultureInfo.InvariantCulture);
            var newDate = date.AddDays(100);
            Console.WriteLine($"{newDate.Day}-{newDate.Month}-{newDate.Year}");

        }
    }
}
