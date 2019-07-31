namespace Exs_05_Special_Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var tires = new List<List<Tire>>();
            var engines = new List<Engine>();
            var cars = new List<Car>();
            var specials = new List<Car>();

            int index = 0;

            while (true)
            {
                string input = Console.ReadLine();  

                if (input == "No more tires") break;

                tires.Add(new List<Tire>());

                var row = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < row.Count; i += 2)
                {
                    tires[index].Add(new Tire(int.Parse(row[i]), double.Parse(row[i + 1])));
                }
                index++;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done") break;

                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                engines.Add(new Engine(int.Parse(parts[0]), double.Parse(parts[1])));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special") break;

                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = parts[0];
                string model = parts[1];
                int year = int.Parse(parts[2]);
                double fuelQuantity = double.Parse(parts[3]);
                double fuelConsumption = double.Parse(parts[4]);
                int engineIndex = int.Parse(parts[5]);
                int tiresIndex = int.Parse(parts[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, 
                                 fuelConsumption, engines[engineIndex], tires[tiresIndex]));
            }

            specials = cars
                .Where(x => x.Year >= 2017 &&
                            x.Engine.HorsePowers > 330 &&
                            x.Tires.Select(y => y.Pressure).Sum() > 9 &&
                            x.Tires.Select(y => y.Pressure).Sum() < 10.0)
                .ToList();

            foreach (var car in specials)
            {
                if (!car.Drive(20))
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
                Console.WriteLine(car.WhoIAm());
            }

        }
    }
}
