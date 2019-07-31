namespace Exs_07_Speed_Racing
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);
                cars.Add(new Car(model, fuel, consumption));

            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End") break;
                var inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inputParts[1];
                double distance = double.Parse(inputParts[2]);
                int index = cars.FindIndex(x => x.Model == model);
                string message = cars[index].Drive(distance);
                if (message != null)
                {
                    Console.WriteLine(message);
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.Distance:F2}");
            }

        }
    }
}
