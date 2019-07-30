namespace Exs_2_Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (true)
            {
                string inp = Console.ReadLine().ToLower();
                if(inp == "end")
                {
                    break;
                }
                string[] parts = inp.Split();
                string command = parts[0];
                switch (command)
                {
                    case "add":
                        stack.Push(int.Parse(parts[1]));
                        stack.Push(int.Parse(parts[2]));
                        break;
                    case "remove":
                        int count = int.Parse(parts[1]);
                        if (stack.Count() >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }
            int sum = 0;
            foreach (var num in stack)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");

        }

        /*static void Remove(int item, Stack<int> st)
        {
            var temp = new Stack<int>();
            while (st.Contains(item))
            {
                    temp.Push(st.Pop());
            }
            temp.Pop();
            int count = temp.Count();
            for (int i = 0; i < count; i++)
            {
                if(temp.Any()) st.Push(temp.Pop());
            }
        }*/

    }
}
