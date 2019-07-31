namespace Exs_07_Speed_Racing
{
    public class Car
    {

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double Distance { get; set; }

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            Distance = 0.0;
        }

        public string Drive(double distance)
        {
            if(distance * Consumption > Fuel)
            {
                return "Insufficient fuel for the drive";
            }
            Fuel -= distance * Consumption;
            Distance += distance;
            return null;
        }

    }
}
