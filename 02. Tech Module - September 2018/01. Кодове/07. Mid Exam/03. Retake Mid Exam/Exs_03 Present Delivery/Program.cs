using System;
using System.Linq;

namespace Exs_03_Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] neededPresents = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            bool[] fullyDelivered = new bool[neededPresents.Length];
            for (int i = 0; i < neededPresents.Length; i++)
            {
                fullyDelivered[i] = false;
            }
            int SantasPosition = 0;
            while (true)
            {
                string jump = Console.ReadLine();
                if (jump == "Merry Xmas!")
                {
                    break;
                }
                string[] parts = jump.Split(' ');
                int length = int.Parse(parts[1]);
                SantasPosition += length;
                while (SantasPosition >= neededPresents.Length)
                {
                    SantasPosition -= neededPresents.Length;
                }
                if (neededPresents[SantasPosition] == 0 && !fullyDelivered[SantasPosition])
                {
                    Console.WriteLine($"House {SantasPosition} will have a Merry Christmas.");
                    fullyDelivered[SantasPosition] = true;
                    continue;
                }
                neededPresents[SantasPosition] -=
                    neededPresents[SantasPosition] == 0 ? 0 : 2;
            }
            Console.WriteLine($"Santa's last position was {SantasPosition}.");
            if (neededPresents.Any(x => x != 0))
            {
                int count = neededPresents.Where(x => x != 0).ToList().Count();
                Console.WriteLine($"Santa has failed {count} houses.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }

        }
    }
}
