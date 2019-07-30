using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nums = numbers;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        nums.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        if(Contains(nums, int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEven(nums);
                        break;
                    case "PrintOdd":
                        PrintOdd(nums);
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(nums));
                        break;
                    case "Filter":
                        Filter(nums, tokens[1], tokens[2]);
                        break;
                }
            }
            string real = string.Join(" ", numbers);
            string newL = string.Join(" ", nums);
            if (real != newL)
            {
                Console.WriteLine(newL);
            }

        }

        static bool Contains(List<int> numbers,int num)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        static void PrintEven(List<int> numbers)
        {
            List<int> nums = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    nums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void PrintOdd(List<int> numbers)
        {
            List<int> nums = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 1)
                {
                    nums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Filter(List<int> numbers, string con, string num)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                bool makeFilter = false;
                switch (con)
                {
                    case "<":
                        makeFilter = numbers[i] < int.Parse(num);
                        break;
                    case ">":
                        makeFilter = numbers[i] > int.Parse(num);
                        break;
                    case "<=":
                        makeFilter = numbers[i] <= int.Parse(num);
                        break;
                    case ">=":
                        makeFilter = numbers[i] >= int.Parse(num);
                        break;
                }
                if (makeFilter)
                {
                    nums.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
