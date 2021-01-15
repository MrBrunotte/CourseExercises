using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance();

            var fuelVehicle = new FuelVehicle("ABC123", 50);
            //Will set the level to 0 which is the min value in the setter!!
            fuelVehicle.FeulLevel = -3;
            var level = fuelVehicle.FeulLevel;
            Console.WriteLine($"The fuel level is always a min of 0. => Level when -3 is set: {level}");
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
