namespace Exs_02_Point_in_Rectangle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var rectangleCoordinates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int topLeftX = int.Parse(rectangleCoordinates[0]);
            int topLeftY = int.Parse(rectangleCoordinates[1]);
            int bottomRightX = int.Parse(rectangleCoordinates[2]);
            int bottomRightY = int.Parse(rectangleCoordinates[3]);
            var rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var pointCoordinates = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int x = int.Parse(pointCoordinates[0]);
                int y = int.Parse(pointCoordinates[1]);
                var point = new Point(x, y);
                Console.WriteLine(rectangle.Contains(point));
            }

        }
    }
}
