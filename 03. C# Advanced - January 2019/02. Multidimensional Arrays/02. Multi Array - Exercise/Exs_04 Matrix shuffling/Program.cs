namespace Exs_04_Matrix_shuffling
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
            var matrix = new string[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new string[m];
                var row = Console.ReadLine().Split(' ',
                                StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = row[j];
                }
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ',
                                                  StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                if (input.Count() != 5 || input[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = int.Parse(input[1]);
                int col1 = int.Parse(input[2]);
                int row2 = int.Parse(input[3]);
                int col2 = int.Parse(input[4]);
                if ((row1 < 0 || row1 >= n) || (row2 < 0 || row2 >= n) ||
                   (col1 < 0 || col2 >= m) || (col2 < 0 || col2 >= m))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string x = matrix[row1][col1];
                matrix[row1][col1] = matrix[row2][col2];
                matrix[row2][col2] = x;
                Console.WriteLine(string.Join(Environment.NewLine,
                    matrix.Select(r => string.Join(' ', r))));
            }

        }
    }
}

