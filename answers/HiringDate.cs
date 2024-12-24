using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answers
{
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor to initialize the hiring date
        public HiringDate(int day, int month, int year)
        {
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
