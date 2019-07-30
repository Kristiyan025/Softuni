namespace Exs_02_2x2_Squares_in_Matrix
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
            var matrix = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                       matrix[i, j] == matrix[i + 1, j] &&
                       matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
