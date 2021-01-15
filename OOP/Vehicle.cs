using System;

namespace OOP
{
    class Vehicle
    {
        public string RegNum { get; set; }

        public Vehicle(string _regNum)
        {
            RegNum = _regNum;
        }

        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle has fuel for a distance of {distance}" : "Error: No fuel!";
    }

    class FuelVehicle : Vehicle
    {
        private double FuelLevel;
        public double FuelCapacity { get; }
        public double FeulLevel
        {
            get
            {
                return FeulLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                FeulLevel = Math.Min(newLevel, FuelCapacity);
            }
        }
        public FuelVehicle(string _regNum, double _fuelCapacity) : base(_regNum)
        {
            FuelCapacity = _fuelCapacity;
        }
    }
     class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double maxDistance => FeulLevel / fuelConsumption;
        public double Milage { get; private set; }
        public FuelCar(string _regNum, double _fuelCapacity) : base(_regNum, _fuelCapacity)
        {
        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
    }
}