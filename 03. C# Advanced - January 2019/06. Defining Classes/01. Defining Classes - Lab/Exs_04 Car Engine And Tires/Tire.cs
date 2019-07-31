namespace Exs_04_Car_Engine_And_Tires
{
    public class Tire
    {

        private int year;

        private double pressure;

        public int Year { get =>  year; set => year = value; }

        public double Pressure { get => pressure; set => pressure = value; }

        public Tire(int year,double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

    }
}
