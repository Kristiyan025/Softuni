using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string vehicle = Console.ReadLine();
                if (vehicle == "End")
                {
                    break;
                }
                string[] properties = vehicle.Split(' ').ToArray();
                string type = properties[0];
                string model = properties[1];
                string color = properties[2];
                int horsePower = int.Parse(properties[3]);
                switch (type)
                {
                    case "car":
                        cars.Add(new Car
                        {
                            Model = model,
                            Color = color,
                            HorsePower = horsePower
                        });
                        break;
                    case "truck":
                        trucks.Add(new Truck
                        {
                            Model = model,
                            Color = color,
                            HorsePower = horsePower
                        });
                        break;
                }
            }
            while (true)
            {
                string model = Console.ReadLine();
                if(model== "Close the Catalogue")
                {
                    break;
                }
                if (cars.Select(x => x.Model).Contains(model))
                {
                    int index = cars.FindIndex(x => x.Model == model);
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {model}");
                    Console.WriteLine($"Color: {cars[index].Color}");
                    Console.WriteLine($"Horsepower: {cars[index].HorsePower}");
                }
                if (trucks.Select(x => x.Model).Contains(model))
                {
                    int index = trucks.FindIndex(x => x.Model == model);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {model}");
                    Console.WriteLine($"Color: {trucks[index].Color}");
                    Console.WriteLine($"Horsepower: {trucks[index].HorsePower}");
                }
            }
            double carsAverageHp = cars.Select(x => x.HorsePower).Average();
            double trucksAverageHp = trucks.Select(x => x.HorsePower).Average();
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHp:F2}.");

        }
    }

    class Truck
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

    class Car
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
