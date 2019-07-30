using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                string[] token = input.Split(' ');
                switch (token[0])
                {
                    case "Delete":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] == int.Parse(token[1]))
                            {
                                nums.Remove(nums[i]);
                            }
                        }
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(token[2]), int.Parse(token[1]));
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
