using System;

namespace Class_tapsiriq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the car's Year,(if you know color write), Brand, Model, Fuel Capacity, Fuel For 1 Km  if the  Current Fuel is known, you can also write it");

            //Car Mercedes = new Car(2022, "Mercedes", "GLS", 80, 7.5);
            //Car Mercedes2 = new Car(2021, "Mercedes", "C-Class", 50, 7.8, 95);


            Car Audi = new Car();
            Audi.Year = int.Parse(Console.ReadLine());
            //Audi.Color = Console.ReadLine();
            Audi.Brand = Console.ReadLine();
            Audi.Model = Console.ReadLine();
            Audi.FuelCapacity = int.Parse(Console.ReadLine());
            Audi.FuelFor1Km = double.Parse(Console.ReadLine());
            //Audi.CurrentFuel = int.Parse(Console.ReadLine());
            Audi.Distance = 50;

            Console.WriteLine(Audi.Drive(50));
        }
    }
}
