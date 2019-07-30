using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {

            int group = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = days * 50;
            for (int i = 1; i <= days; i++)
            {
                if (i % 15 == 0)
                {
                    group += 5;
                }
                if (i % 10 == 0)
                {
                    group -= 2;
                }
                if (i % 5 == 0)
                {
                    coins += (20 * group);
                }
                if (i % 3 == 0)
                {
                    coins -= (3 * group);
                }
                if (i % 15 == 0)
                {
                    coins -= (2 * group);
                }
                coins -= (2 * group);
            }
            double each = coins / group;
            Math.Floor(each);
            Console.WriteLine($"{group} companions received {each} coins each.");
            
        }
    }
}
