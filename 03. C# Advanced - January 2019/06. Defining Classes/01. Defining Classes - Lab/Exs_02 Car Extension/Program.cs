namespace Exs_02_Car_Extension
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            if (!car.Drive(2000))
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            Console.WriteLine(car.WhoIAm());

        }
    }
}
