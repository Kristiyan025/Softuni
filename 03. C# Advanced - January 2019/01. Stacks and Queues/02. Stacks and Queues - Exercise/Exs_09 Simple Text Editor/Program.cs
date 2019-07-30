namespace Exs_09_Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder s = new StringBuilder();
            var previous = new Stack<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string ind = command[0];
                switch (ind) // index
                {
                    case "1":
                        previous.Push(s.ToString());
                        s.Append(command[1]);
                        break;
                    case "2":
                        previous.Push(s.ToString());
                        int count = int.Parse(command[1]);
                        s.Remove(s.Length - count, count);
                        break;
                    case "3":
                        Console.WriteLine(s[int.Parse(command[1]) - 1]);
                        break;
                    case "4":
                        s.Clear();
                        s.Append(previous.Pop());
                        break;
                }
            }

        }
    }
}
