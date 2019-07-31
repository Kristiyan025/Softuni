namespace Exs_08_Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                var engine = new Engine { Speed = speed, Power = power };
                int weight = int.Parse(input[3]);
                string type = input[4];
                var cargo = new Cargo { Weight = weight, Type = type };
                double pressure1 = double.Parse(input[5]);
                int age1 = int.Parse(input[6]);
                double pressure2 = double.Parse(input[7]);
                int age2 = int.Parse(input[8]);
                double pressure3 = double.Parse(input[9]);
                int age3 = int.Parse(input[10]);
                double pressure4 = double.Parse(input[11]);
                int age4 = int.Parse(input[12]);
                var tires = new Tire[4]
                {
                    new Tire{ Pressure = pressure1, Age = age1},
                    new Tire{ Pressure = pressure2, Age = age2},
                    new Tire{ Pressure = pressure3, Age = age3},
                    new Tire{ Pressure = pressure4, Age = age4}
                };
                cars.Add(new Car(model, engine, cargo, tires));
            }
            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    Console.WriteLine(string.Join(Environment.NewLine,
                        cars.Where(x => x.Cargo.Type == "fragile" && 
                                        x.Tires[0].Pressure < 1 &&
                                        x.Tires[1].Pressure < 1 &&
                                        x.Tires[2].Pressure < 1 &&
                                        x.Tires[3].Pressure < 1)));
                    break;
                case "flamable":
                    Console.WriteLine(string.Join(Environment.NewLine,
                        cars.Where(x => x.Cargo.Type == "flamable" &&
                                        x.Engine.Power > 250)));
                    break;
            }

        }
    }
}
