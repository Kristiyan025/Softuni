namespace Exs_05_Snake_Moves
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
        var matrix = new char[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new char[m];
        }
        string snake = Console.ReadLine();
        int currentI = 0, currentJ = 0;
        int currentIndex = 0;
        while (true)
        {
            matrix[currentI][currentJ] = snake[currentIndex];
            currentJ++;
            if (currentJ == m)
            {
                currentJ = 0;
                currentI++;
                if (currentI == n)
                {
                    break;
                }
            }
            currentIndex++;
            if (currentIndex == snake.Length)
            {
                currentIndex = 0;
            }
        }
        Console.WriteLine(
            string.Join(Environment.NewLine,
            matrix.Select(r => string.Join("", r))));

    }
}
}

