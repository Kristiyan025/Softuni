namespace Exs_04_Symbol_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            char symbol = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix"); 

        }
    }
}
