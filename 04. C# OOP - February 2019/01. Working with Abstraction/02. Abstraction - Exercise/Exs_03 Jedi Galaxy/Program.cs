namespace Exs_03_Jedi_Galaxy
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            // reading dimenions from console
            var dimesions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int x = dimesions[0];
            int y = dimesions[1];

            // initializing the matrix and its values
            var matrix = new int[x][];
            int value = 0;
            for (int i = 0; i < x; i++)
            {
                matrix[i] = new int[y];
                for (int j = 0; j < y; j++)
                {
                    matrix[i][j] = value++;
                }
            }
            
            //reading ivo's and evil's coordinates
            var ivoCoordinates = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            var evilCoordinates = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            int ivoX = ivoCoordinates[0];
            int ivoY = ivoCoordinates[1];
            int evilX = evilCoordinates[0];
            int evilY = evilCoordinates[1];

            while (evilX >= 0 && evilY >= 0)
            {
                if (isOnMatrix(evilX, evilY, x, y))
                {
                    matrix[evilX][evilY] = 0;
                }
                evilX--;
                evilY--;
            }

            long sum = 0;
            while (ivoX >= 0 && ivoY < y)
            {
                if (isOnMatrix(ivoX, ivoY, x, y))
                {
                    sum += matrix[ivoX][ivoY];
                }
                ivoX--;
                ivoY++;
            }

            string command = Console.ReadLine();
            Console.WriteLine(sum);

        }

        static bool isOnMatrix(int i, int j, int x, int y)
        {
            bool isInHorizontal = i >= 0 && i < x;
            bool isInVertical = j >= 0 && j < y;
            return isInHorizontal && isInVertical;
        }
    }
}
