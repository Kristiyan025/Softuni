using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Baking_Rush
{
    class Program
    {
        static void Main(string[] args)
        {

            int energy = 100;
            int coins = 100;
            string input = Console.ReadLine();
            string[] events = input.Split('|');
            bool isDayCompleted = true;
            for (int i = 0; i < events.Length; i++)
            {
                string[] eventOrIngredient = events[i].Split('-');
                string evOrIn = eventOrIngredient[0];
                int number = int.Parse(eventOrIngredient[1]);
                switch (evOrIn)
                {
                    case "rest":
                        if (energy + number > 100)
                        {
                            number = 100 - energy;
                        }
                        energy += number;
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                        break;
                    case "order":
                        energy -= 30;
                        if (energy < 0)
                        {
                            energy += 80;
                            Console.WriteLine("You had to rest!");
                        }
                        else
                        {
                            coins += number;
                            Console.WriteLine($"You earned {number} coins.");
                        }
                        break;
                    default:
                        coins -= number;
                        if (coins <= 0)
                        {
                            Console.WriteLine($"Closed! Cannot afford {evOrIn}.");
                            isDayCompleted = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"You bought {evOrIn}.");
                        }
                        break;
                }
                if (!isDayCompleted)
                {
                    break;
                }
            }
            if (isDayCompleted)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }

        }
    }
}
