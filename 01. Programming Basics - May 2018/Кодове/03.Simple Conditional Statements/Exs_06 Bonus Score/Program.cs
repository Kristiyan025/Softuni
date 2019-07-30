using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Дадено е цяло число – брой точки:
            Ако числото е до 100 включително, бонус точките са 5
            Ако числото е по-голямо от 100, бонус точките са 20%
            Ако числото е по-голямо от 1000, бонус точките са 10%
            Допълнителни бонус точки:
            За четно число  1 т.
            За число, което завършва на 5  2 т.
           */
            Console.Write("Enter score: ");
            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0.0;
            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if ((num > 100) && (num <= 1000))
            {
                bonusScore = num * 0.20;
            }
            else if (num > 1000)
            {
                bonusScore = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore += 2;
            }
            double totalScore = num + bonusScore;
            Console.WriteLine("Bonus score is: " + bonusScore.ToString());
            Console.WriteLine("Total score is: " + totalScore.ToString());

        }
    }
}
