using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

           /*
           Работните дни:
           плод     banana  apple   orange  grapefruit  kiwi   pineapple  grapes

           цена     2.50    1.20    0.85    1.45        2.70   5.50       3.85

           Събота и неделя:
           плод     banana  apple   orange  grapefruit  kiwi   pineapple  grapes

           цена     2.70    1.25    0.90    1.60        3.00   5.60       4.20
           */
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quan = double.Parse(Console.ReadLine());
            bool dali = true;
            if (day == "monday" || day == "tuesday" || day == "wednesday" ||
                day == "thursday" || day == "friday")
            {
                if (fruit == "banana") quan *= 2.50;
                else if (fruit == "apple") quan *= 1.20;
                else if (fruit == "orange") quan *= 0.85;
                else if (fruit == "grapefruit") quan *= 1.45;
                else if (fruit == "kiwi") quan *= 2.70;
                else if (fruit == "pineapple") quan *= 5.50;
                else if (fruit == "grapes") quan *= 3.85;
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") quan *= 2.70;
                else if (fruit == "apple") quan *= 1.25;
                else if (fruit == "orange") quan *= 0.90;
                else if (fruit == "grapefruit") quan *= 1.60;
                else if (fruit == "kiwi") quan *= 3.00;
                else if (fruit == "pineapple") quan *= 5.60;
                else if (fruit == "grapes") quan *= 4.20;
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else
            {
                Console.WriteLine("error");
                dali = false;
            }
            if (dali == true)
            {
                Console.WriteLine(quan.ToString("0.00"));
            }

        }
    }
}
