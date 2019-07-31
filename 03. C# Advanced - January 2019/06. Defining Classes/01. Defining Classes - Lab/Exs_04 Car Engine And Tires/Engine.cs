namespace Exs_04_Car_Engine_And_Tires
{
    public class Engine
    {

        private int horsePowers;

        private double cubicCapacity;

        public int HorsePowers { get => horsePowers; set => horsePowers = value; }

        public double CubicCapacity { get => cubicCapacity; set => cubicCapacity = value; }

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePowers = horsePower;
            CubicCapacity = cubicCapacity;
        }

    }
}
