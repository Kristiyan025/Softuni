namespace Exs_06_Bomb_the_Basement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            var bombProps = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int cellI = bombProps[0];
            int cellJ = bombProps[1];
            int bombR = bombProps[2];
            var matrix = new char[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new char[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = '0';
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int currentR = (Math.Abs(i - cellI) + Math.Abs(j - cellJ));
                    if (currentR <= bombR)
                    {
                        matrix[i][j] = '1';
                    }
                }
            }
            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(matrix[i][j] == 1 && matrix[i - 1][j] == 0)
                    {
                        matrix[i][j] = 0;
                        matrix[i - 1][j] = 1;
                    }
                }
            }*/
            for (int j = 0; j < m; j++)
            {
                string s = string.Join("", matrix.Select(r => r[j]));
                int ones = 0, zeros = 0;
                foreach (var ch in s)
                {
                    if (ch == '1') ones++;
                    else zeros++;
                }
                string newS = new string('1', ones) + new string('0', zeros);
                for (int i = 0; i < n; i++)
                {
                    matrix[i][j] = newS[i];
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine,
                matrix.Select(r => string.Join("", r))));

        }
    }
}
