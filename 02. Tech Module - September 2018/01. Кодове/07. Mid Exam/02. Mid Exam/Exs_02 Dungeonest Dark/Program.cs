using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 100;
            int coins = 0;
            string dungeon = Console.ReadLine();
            string[] rooms = dungeon.Split('|').ToArray();
            int reachment = 0;
            bool isAlive = true;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] room = rooms[i].Split(' ').ToArray();
                string itOrMo = room[0];
                switch (itOrMo)
                {
                    case "potion":
                        int hp = int.Parse(room[1]);
                        if ((health + hp) < 100)
                        {
                            health += hp;
                        }
                        else
                        {
                            hp = 100 - health;
                            health = 100;

                        }
                        Console.WriteLine($"You healed for {hp} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;

                    case "chest":
                        int co = int.Parse(room[1]);
                        coins += co;
                        if (co > reachment)
                        {
                            reachment = i;
                        }
                        Console.WriteLine($"You found {co} coins.");
                        break;

                    default:
                        string monster = itOrMo;
                        int attack = int.Parse(room[1]);
                        if (attack < health)
                        {
                            health -= attack;
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            health = 0;
                            isAlive = false;
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {reachment + 2}");
                        }
                        break;
                }
                if (!isAlive)
                {
                    break;
                }
            }
            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
