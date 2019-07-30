using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "End")
                {
                    break;
                }
                string[] token = input.Split(' ');
                switch (token[0])
                {
                    case "Add":
                        nums.Add(int.Parse(token[1]));
                        break;
                    case "Insert":
                        if (int.Parse(token[2]) < nums.Count && int.Parse(token[1]) >= 0)
                        {
                            nums.Insert(int.Parse(token[2]), int.Parse(token[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(token[1]) < nums.Count && int.Parse(token[1]) >= 0)
                        {
                            nums.RemoveAt(int.Parse(token[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        for (int i = 0; i < int.Parse(token[2]); i++)
                        {
                            if (token[1] == "left")
                            {
                                nums.Add(nums[0]);
                                nums.RemoveAt(0);
                            }
                            else if (token[1] == "right")
                            {
                                nums.Insert(0, nums[nums.Count - 1]);
                                nums.RemoveAt(nums.Count - 1);
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",nums));

        }
    }
}
