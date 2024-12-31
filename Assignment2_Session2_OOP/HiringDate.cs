using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Session2_OOP
{
    internal class HiringDate
    {
         int day;
         int month { get; set; }
         int year { get; set; }

        // the necessary Properties (Instead of setters and getters)
        public int Day
        {
            get { return day; }
            set { day = (value >= 1 && value <= 31 )?value : throw new ArgumentOutOfRangeException("Day must be between 1 and 31."); }
        }

        public int Month
        {
            get { return month; }
            set { month = (value >= 1 && value < 12) ? value : throw new ArgumentOutOfRangeException("Month must be between 1 and 12."); }
        }

        public int Year
        {
            get { return year; }
            set { year = (value >= 1900 && value <= DateTime.Now.Year) ? value : throw new ArgumentOutOfRangeException("Year must be between 1900 and the current year."); }
        }

        public HiringDate(int day , int month , int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int CompareTo(HiringDate other)
        {
            if (this.Year != other.Year)
                return this.Year.CompareTo(other.Year);
            if (this.Month != other.Month)
                return this.Month.CompareTo(other.Month);
            return this.Day.CompareTo(other.Day);
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}
