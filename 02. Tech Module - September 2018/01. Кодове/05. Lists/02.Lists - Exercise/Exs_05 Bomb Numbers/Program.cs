using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] bombAndPower = Console.ReadLine().Split(' ');
            int bomb = int.Parse(bombAndPower[0]);
            int power = int.Parse(bombAndPower[1]);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    for (int j = i + power; j >= i - power; j--)
                    {
                        if (j >= 0 && j < nums.Count)
                        {
                            nums.RemoveAt(j);
                        }
                    }
                    i -= power;
                    i--;
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);

        }
    }
}
