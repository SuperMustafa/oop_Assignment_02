using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_02
{
    internal class HireDate
    {

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31) throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            if (year < 1900 || year > DateTime.Now.Year) throw new ArgumentOutOfRangeException(nameof(year), "Year must be a valid past year.");

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}
