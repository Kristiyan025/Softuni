namespace Exs_01_Diagonal_Difference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            /*int first = 0;
            int second = 0;
            for (int i = 0; i < n; i++)
            {
                first += matrix[i][i];
                second += matrix[i][n - i - 1];
            }*/
            double razlika = 0;
            for (int i = 0; i < n; i++)
            {
                razlika += (matrix[i][i] - matrix[i][n - i - 1]);
            }
            Console.WriteLine(Math.Abs(razlika));

        }
    }
}
