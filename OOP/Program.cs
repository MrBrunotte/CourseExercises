using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance();

            var demo = new Demo(new ConsoleUI());

            var fuelVehicle = new FuelVehicle("ABC123", 50);
            //Will set the level to 0 which is the min value in the setter!!
            fuelVehicle.FuelLevel = -3;
            var level = fuelVehicle.FuelLevel;
            Console.WriteLine($"The fuel level is always a min of 0. => Level when -3 is set: {level}");

            List<IDrive> vehicles = new List<IDrive>
            {
                new FuelVehicle("ABS", 50),
                new FuelVehicle("ABD", 50),
                new FuelCar("CFD", 20),
                new Bicycle("12356")
            };

            foreach (IDrive vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(20));

                FuelCar fuelCar1 = vehicle as FuelCar;

                // ? nullcheck!
                Console.WriteLine("Tut tut: ? print with null check");
                Console.WriteLine(fuelCar1?.DoSound());

                if (fuelCar1 != null)
                {
                    Console.WriteLine("Tut tut: Print with if condition");
                    Console.WriteLine(fuelCar1.DoSound());
                }

                if (vehicle is FuelCar)
                {
                    FuelCar fuelCar = (FuelCar)vehicle;
                    Console.WriteLine("Tut tut with if condition: is");
                    Console.WriteLine(fuelCar.DoSound());

                }

                if (vehicle is FuelCar car)
                {
                    Console.WriteLine("Tut tut: with Direct cast");
                    Console.WriteLine(car.DoSound());
                }
            }
        }

        private static void Inheritance()
        {
            // Access only to Name
            Arv1 arv1 = new Arv3();
            arv1.Name = "Stefan";

            // Access only to Name and Age
            Arv2 arv2 = new Arv3();
            arv2.Name = "Stefan";
            arv2.Age = 48;

            // Access to all three classes and parameters Name, Age and Address
            Arv3 arv3 = new Arv3();
            arv3.Name = "Stefan";
            arv3.Age = 48;
            arv3.Adress = "Krukmakargatan 29";
        }
    }
}
