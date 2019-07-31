namespace Exs_04_Hotel_Reservation
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {

            var inputParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double pricePerDay = double.Parse(inputParts[0]);
            int days = int.Parse(inputParts[1]);
            int season = 0;
            int discount = 0;
            switch (inputParts[2]) //season as string
            {
                case "Autumn":
                    season = (int)Season.Autumn;
                    break;
                case "Spring":
                    season = (int)Season.Spring;
                    break;
                case "Winter":
                    season = (int)Season.Winter;
                    break;
                case "Summer":
                    season = (int)Season.Summer;
                    break;
            }
            if(inputParts.Length > 3)
                switch (inputParts[3]) //discount as string
                {
                    case "SecondVisit":
                        discount = (int)Discount.SecondVisit;
                        break;
                    case "VIP":
                        discount = (int)Discount.VIP;
                        break;
                }
            Holiday holiday = new Holiday(pricePerDay, days, season, discount);
            Console.WriteLine(holiday.CalculatePrice());

        }
    }
}
