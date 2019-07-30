using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if ((age >= 0 && age <= 18) && day == "Weekday")
            {
                Console.WriteLine("12$");
            }
            else if ((age >= 0 && age <= 18) && day == "Weekend")
            {
                Console.WriteLine("15$");
            }
            else if ((age > 64 && age <= 122) && day == "Weekday")
            {
                Console.WriteLine("12$");
            }
            else if ((age > 64 && age <= 122) && day == "Weekend")
            {
                Console.WriteLine("15$");
            }
            else if ((age >= 0 && age <= 18) && day == "Holiday")
            {
                Console.WriteLine("5$");
            }
            else if ((age > 64 && age <= 122) && day == "Holiday")
            {
                Console.WriteLine("10$");
            }
            else if ((age > 18 && age <= 64) && day == "Weekday")
            {
                Console.WriteLine("18$");
            }
            else if ((age > 18 && age <= 64) && day == "Weekend")
            {
                Console.WriteLine("20$");
            }
            else if ((age > 18 && age <= 64) && day == "Holiday")
            {
                Console.WriteLine("12$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
