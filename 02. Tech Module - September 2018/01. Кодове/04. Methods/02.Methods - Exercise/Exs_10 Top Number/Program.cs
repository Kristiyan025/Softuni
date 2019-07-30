using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            for (int i = 1; i < Convert.ToInt32(number); i++)
            {
                if (TopNumberChecker(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool TopNumberChecker(string number)
        {
            int digitSum = 0;
            bool isOnlyEven = true;
            for (int i = 0; i < number.Length; i++)
            {
                digitSum += Convert.ToInt32(number[i]);
                if (Convert.ToInt32(number[i]) % 2 == 1)
                {
                    isOnlyEven = false;
                }
            }
            bool isEightDivisible = digitSum % 8 == 0 ? true : false;
            if (!isOnlyEven && isEightDivisible) return true;
            else return false;
        }
    }
}
