namespace Exs_4_Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            var stack = new Stack<int>();
            var list = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    list.Add(input.Substring(stack.Peek(), (i - stack.Pop() + 1)));
                }
            }
            foreach (var br in list)
            {
                Console.WriteLine(br);
            }

        }
    }
}
