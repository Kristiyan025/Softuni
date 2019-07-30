using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_13_Holidays_Between_2_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy",
                CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy",
                CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (; startDate <= endDate; startDate = startDate.AddDays(1))
            {
                if (startDate.DayOfWeek == DayOfWeek.Saturday ||
                    startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
