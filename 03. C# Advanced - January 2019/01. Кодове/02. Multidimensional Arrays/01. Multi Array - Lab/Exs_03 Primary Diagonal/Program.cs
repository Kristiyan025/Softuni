namespace Exs_03_Primary_Diagonal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);

        }
    }
}
