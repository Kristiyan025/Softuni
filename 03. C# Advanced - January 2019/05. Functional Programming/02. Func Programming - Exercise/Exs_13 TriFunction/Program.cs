namespace Exs_13_TriFunction
{
    using System;
    using System.Collections;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int sum;
            for (int i = 0; i < names.Count; i++)
            {
                sum = 0;
                foreach (var ch in names[i])
                {
                    sum += Convert.ToInt16(ch);
                }
                if (sum >= n)
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }

        }
    }
}
