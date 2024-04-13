using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date()
        {
            year = 2024;
            month = 4;
            day = 13;
        }

        public Date(int year,int month,int day)
        {
            this.year = year;
            this.month = month; 
            this.day = day;
            
        }

        public String Display()
        {
            return $"\nDetails: {year}/{month}/{day}";
        }
    }
}
