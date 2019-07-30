namespace Exs_05_Square_With_Maximum_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var matrix = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            var searched = new int[,] { { matrix[0, 0], matrix[0, 1] }, { matrix[1, 0], matrix[1, 1] } };
            int sum = matrix[0, 0] + matrix[0, 1] + matrix[1, 0] + matrix[1, 1];
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum1 = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum < sum1)
                    {
                        sum = sum1;
                        searched = new int[,] { { matrix[i, j], matrix[i, j + 1] }, { matrix[i + 1, j], matrix[i + 1, j + 1] } };
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(searched[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);

        }
    }
}
