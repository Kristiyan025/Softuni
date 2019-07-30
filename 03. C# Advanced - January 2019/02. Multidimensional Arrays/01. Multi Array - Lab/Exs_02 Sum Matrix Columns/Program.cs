namespace Exs_02_Sum_Matrix_Columns
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
                var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            var sum = new int[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i] += matrix[j, i];
                }
            }
            foreach (var column in sum)
            {
                Console.WriteLine(column);
            }

        }
    }
}
