namespace Exs_04_Hotel_Reservation
{
    public class Holiday
    {
        
        private double pricePerDay;
        private int days;
        private int season;
        private int discount;

        public Holiday(double pricePerDay, int days, int season, int discount)
        {
            this.pricePerDay = pricePerDay;
            this.days = days;
            this.season = season;
            this.discount = discount;
        }

        public string CalculatePrice()
        {
            double price = this.pricePerDay * this.days * this.season * (1.00 - discount / 100.0);
            return $"{price:F2}";
        }

    }
}
