namespace Exs_06_Jagged_Array_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            while (true)
            {
                string[] commandProp = Console.ReadLine().Split();
                if (commandProp[0] == "END")
                {
                    break;
                }
                string command = commandProp[0];
                int row = int.Parse(commandProp[1]);
                int column = int.Parse(commandProp[2]);
                int value = int.Parse(commandProp[3]);
                if(row < 0 || column < 0 || row >= n || column >= n)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                switch (command)
                {
                    case "Add":
                        matrix[row, column] += value;
                        break;
                    case "Subtract":
                        matrix[row, column] -= value;
                        break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
