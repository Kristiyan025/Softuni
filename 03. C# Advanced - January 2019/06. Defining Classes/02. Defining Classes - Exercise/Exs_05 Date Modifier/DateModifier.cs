using System;
using System.Globalization;

namespace Exs_05_Date_Modifier
{
    public class DateModifier
    {

        private int days;

        public int Days { get => days; set => days = value; }

        public void CalculateDifference(string start, string end)
        {
            var startDate = DateTime.ParseExact(start, "yyyy mm dd", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(end, "yyyy mm dd", CultureInfo.InvariantCulture);
            Days = (int)Math.Abs((endDate - startDate).TotalDays) + 30;
        }

    }
}
