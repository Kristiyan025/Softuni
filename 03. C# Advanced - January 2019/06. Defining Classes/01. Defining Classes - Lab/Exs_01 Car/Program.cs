namespace Exs_01_Car
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            System.Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

        }
    }
}
