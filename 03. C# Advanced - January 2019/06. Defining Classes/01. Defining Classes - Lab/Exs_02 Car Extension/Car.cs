namespace Exs_02_Car_Extension
{
    public class Car
    {

        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

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
