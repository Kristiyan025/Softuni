namespace Exs_07_Knight_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n][];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new char[n];
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            while (true)
            {
                int maxi = -1;
                int maxiI = -1, maxiJ = -1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i][j] == 'K')
                        {
                            int current = Count(i, j, matrix, n);
                            if (maxi < current)
                            {
                                maxi = current;
                                maxiI = i;
                                maxiJ = j;
                            }
                        }
                    }
                }
                if (maxi == 0)
                {
                    break;
                }
                matrix[maxiI][maxiJ] = '0';
                count++;
            }
            Console.WriteLine(count);

        }

        static bool IsInMatrix(int i, int j, int n)
        {
            return i >= 0 && i < n && j >= 0 && j < n;
        }

        static int Count(int i, int j, char[][] matrix, int n)
        {
            int count = 0;
            if (IsInMatrix(i - 1, j - 2, n) && matrix[i - 1][j - 2] == 'K') count++;
            if (IsInMatrix(i - 2, j - 1, n) && matrix[i - 2][j - 1] == 'K') count++;
            if (IsInMatrix(i - 2, j + 1, n) && matrix[i - 2][j + 1] == 'K') count++;
            if (IsInMatrix(i - 1, j + 2, n) && matrix[i - 1][j + 2] == 'K') count++;
            if (IsInMatrix(i + 1, j + 2, n) && matrix[i + 1][j + 2] == 'K') count++;
            if (IsInMatrix(i + 2, j + 1, n) && matrix[i + 2][j + 1] == 'K') count++;
            if (IsInMatrix(i + 2, j - 1, n) && matrix[i + 2][j - 1] == 'K') count++;
            if (IsInMatrix(i + 1, j - 2, n) && matrix[i + 1][j - 2] == 'K') count++;
            return count;
        }
    }
}
