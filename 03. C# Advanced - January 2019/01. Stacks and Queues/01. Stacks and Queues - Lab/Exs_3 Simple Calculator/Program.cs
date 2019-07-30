namespace Exs_3_Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var values = input.Split(' ');
            var stack = new Stack<string>(values.Reverse());
            int sum = int.Parse(stack.Pop());
            while (stack.Any())
            {
                string op = stack.Pop();
                int second = int.Parse(stack.Pop());
                switch (op)
                {
                    case "+":
                        sum += second;
                        break;
                    case "-":
                        sum -= second;
                        break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
