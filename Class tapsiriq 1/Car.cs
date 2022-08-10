using System;
using System.Collections.Generic;
using System.Text;

namespace Class_tapsiriq_1
{
    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public int CurrentFuel;
        public int Distance;
        public void ShowInfo() 
        { 
        }
        public Car()
        {

        }
        public Car(int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km) : base(Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;

        }
        public Car(int Year, string Color, string Brand, string Model, int FuelCapacity, double FuelFor1Km):base(Year,Color)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;

        }
        public Car(int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km, int CurrentFuel) : this(Year, Brand, Model, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }
        public Car(int Year, string Color, string Brand, string Model, int FuelCapacity, double FuelFor1Km ,int CurrentFuel): this(Year,Color,Brand,Model,FuelCapacity,FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }
            
        public double Drive(int Distance)
        {
            double Fuelremain = 0;
            if (Distance<=FuelCapacity/FuelFor1Km)
            {
                Fuelremain =FuelCapacity * FuelFor1Km - Distance;
            }
            return Fuelremain;
        }

    }

}
