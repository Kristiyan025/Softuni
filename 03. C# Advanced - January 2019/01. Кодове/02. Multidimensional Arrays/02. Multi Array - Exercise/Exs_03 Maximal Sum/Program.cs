namespace Exs_03_Maximal_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            var matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int maxSum = 0;
            int[,] maxi = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    maxi[i, j] = matrix[i, j];
                }
            }
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    int curSum = 0;
                    var current = new int[3, 3];
                    for (int l = i; l < i + 3; l++)
                    {
                        for (int p = j; p < j + 3; p++)
                        {
                            curSum += matrix[l, p];
                            current[l - i, p - j] = matrix[l, p];
                        }
                        if (maxSum < curSum)
                        {
                            maxSum = curSum;
                            maxi = current;
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(maxi[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
