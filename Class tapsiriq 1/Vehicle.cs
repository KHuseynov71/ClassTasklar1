using System;
using System.Collections.Generic;
using System.Text;

namespace Class_tapsiriq_1
{
    class Vehicle
    {
        public int Year;
        public string Color;

        public Vehicle()
        {

        }
        public Vehicle(int Year)
        {
            this.Year = Year;
        }
        public Vehicle(int Year, string Color): this(Year)
        {
            this.Color = Color;
        }
    }
    
}
