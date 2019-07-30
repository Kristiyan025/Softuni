namespace Exs_01_Reverse_Strings
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            var reversed = new Stack<char>();
            foreach (var ch in input)
            {
                reversed.Push(ch);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(reversed.Pop());
            }

        }
    }
}
