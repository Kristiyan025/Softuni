namespace Exs_01_Sum_Matrix_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            var matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(m);
            int sum = 0;
            foreach (var cell in matrix)
            {
                sum += cell;
            }
            Console.WriteLine(sum);

        }
    }
}
