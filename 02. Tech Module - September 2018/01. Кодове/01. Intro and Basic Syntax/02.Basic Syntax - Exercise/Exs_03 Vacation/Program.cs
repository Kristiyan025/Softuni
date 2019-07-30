using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine();
            double forOne = 0;
            double total = 1;
            if (type == "students")
            {
                if (day == "Friday")
                {
                    forOne = 8.45;
                }
                else if (day == "Saturday")
                {
                    forOne = 9.80;
                }
                else if (day == "Sunday")
                {
                    forOne = 10.46;
                }
            }
            else if (type == "business")
            {
                if (day == "Friday")
                {
                    forOne = 10.90;
                }
                else if (day == "Saturday")
                {
                    forOne = 15.60;
                }
                else if (day == "Sunday")
                {
                    forOne = 16.00;
                }
            }
            else if (type == "regular")
            {
                if (day == "Friday")
                {
                    forOne = 15.00;
                }
                else if (day == "Saturday")
                {
                    forOne = 20.00;
                }
                else if (day == "Sunday")
                {
                    forOne = 22.50;
                }
            }
            if (count >= 30 && type == "students")
            {
                total *= 0.85;
            }
            else if (count >= 100 && type == "business")
            {
                count -= 10;
            }
            else if (count >= 10 && count <= 20 && type == "regular")
            {
                total *= 0.95;
            }
            total *= (count * forOne);
            Console.WriteLine($"Total price: {total:F2}");

        }
    }
}
