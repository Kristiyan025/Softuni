namespace Exs_04_Car_Engine_And_Tires
{
    class Car
    {

        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        private Engine engine;

        private Tire[] tires;

        public string Make { get => make; set => make = value; }

        public string Model { get => model; set => model = value; }

        public int Year { get => year; set => year = value; }

        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }

        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public Engine Engine { get => engine; set => engine = value; }

        public Tire[] Tires { get => tires; set => tires = value; }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200.00;
            FuelConsumption = 10.00;
        }

        public Car(string make, string model, int year)
            : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, 
                   double fuelConsumption, Engine engine, Tire[] tires)
            :this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public bool Drive(double distance)
        {
            if (FuelQuantity - distance * FuelConsumption > 0)
            {
                FuelQuantity -= distance * FuelConsumption;
                return true;
            }

            return false;
        }

        public string WhoIAm()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
        }

    }
}
