using System;
using System.Text;

namespace OOP
{
    public interface IDrive
    {
        string Drive(double distance);

    }
    abstract class AbstractVehicle : IDrive
    {
        // An Abstract class cannot instantiate any objects!
        public virtual string Drive(double distance) => $"Vehicle has fuel for a distance of {distance}";
        // Same thing but written like a "normal" method:

        //public virtual string Drive(double distance)
        //{
        //    return $"Vehicle has fuel for a distance of {distance}";
        //}

        public abstract string Turn();

    }

    class Bicycle : AbstractVehicle
    {
        public string FrameNumber { get; set; }
        public Bicycle(string _frameNumber)
        {
            FrameNumber = _frameNumber;
        }

        public override string Turn() => "Bicycle turns";

        public override string Drive(double distance)
        {
            return "Bicycle starts peddling";
        }
    }



    class Vehicle : AbstractVehicle
    {
        protected string RegNum { get; set; }

        public Vehicle(string _regNum)
        {
            RegNum = _regNum;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    class FuelVehicle : Vehicle
    {
        private double fuelLevel;
        public double FuelCapacity { get; }
        public double FuelLevel
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity);
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
        public double maxDistance => FuelLevel / fuelConsumption;
        public double Milage { get; private set; }
        public FuelCar(string _regNum, double _fuelCapacity) : base(_regNum, _fuelCapacity)
        {
        }

        public string DoSound() => "Tut tut";

        public override string Drive(double distance)
        {
            var result = new StringBuilder();
            result.AppendLine(base.Drive(distance));

            if (distance < 0)
            {
                distance = 0;
                result.AppendLine($"Negative distance is assumed to be 0.");
            }

            FuelLevel = FuelLevel - (distance * fuelConsumption);
            //FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNum: {RegNum} drove {distance} km");

            return result.ToString();


        }
    }
}