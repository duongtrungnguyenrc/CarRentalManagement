using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PricesModel
    {
        public static double GetRentTime(DateTime rentalStartDate, DateTime rentalEndDate, DateTime rentalStartTime, DateTime rentalEndTime)
        {
            DateTime startDateTime = rentalStartDate.Date + rentalStartTime.TimeOfDay;
            DateTime endDateTime = rentalEndDate.Date + rentalEndTime.TimeOfDay;

            TimeSpan duration = endDateTime - startDateTime;
            int days = duration.Days;
            double hours = duration.TotalHours - (days * 24);

            return Math.Round(days * 24 + hours);
        }

        public static double CalcPrices(double rentalPrice, double rentalTime)
        {
            return rentalTime * rentalPrice;
        }
    }
}
