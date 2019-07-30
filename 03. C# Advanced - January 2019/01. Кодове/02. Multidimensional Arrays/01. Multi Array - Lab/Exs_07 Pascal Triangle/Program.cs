namespace Exs_07_Pascal_Triangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new long[n][];
            for (int i = 1; i <= n; i++)
            {
                matrix[i - 1] = new long[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if(i == 0 || j == 0 || j == matrix[i].Length - 1)
                    {
                        matrix[i][j] = 1;
                    }
                    else
                    {
                        matrix[i][j] = matrix[i - 1][j] + matrix[i - 1][j - 1];
                    }
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
