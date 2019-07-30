using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Vehicle_Catalogue
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
                if (vehicle == "end")
                {
                    break;
                }
                string[] properties = vehicle.Split('/').ToArray();
                string type = properties[0];
                string brand = properties[1];
                string model = properties[2];
                switch (type)
                {
                    case "Car":
                        int horsePower = int.Parse(properties[3]);
                        cars.Add(new Car
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = horsePower
                        });
                        break;
                    case "Truck":
                        int weight = int.Parse(properties[3]);
                        trucks.Add(new Truck
                        {
                            Brand = brand,
                            Model = model,
                            Weight = weight
                        });
                        break;
                }
            }
            cars = cars.OrderBy(n => n.Brand).ToList();
            trucks = trucks.OrderBy(n => n.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
}
