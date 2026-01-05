using System;

namespace CG_Practice.oopscsharp.VehicleRentalSystem
{
    // base vehicle class
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;
        private string policyNumber;

        public string VehicleNumber { get { return vehicleNumber; } set { vehicleNumber = value; } }
        public string Type { get { return type; } set { type = value; } }
        public double RentalRate { get { return rentalRate; } set { rentalRate = value; } }
        protected string PolicyNumber { get { return policyNumber; } set { policyNumber = value; } }

        public Vehicle(string number, string vehicleType, double rate)
        {
            vehicleNumber = number;
            type = vehicleType;
            rentalRate = rate;
            policyNumber = "POL" + number;
        }

        // must be implemented by child classes
        public abstract double CalculateRentalCost(int days);

        public void ShowVehicleInfo()
        {
            Console.WriteLine("Vehicle: " + vehicleNumber + " | Type: " + type);
            Console.WriteLine("Rate: $" + rentalRate + "/day");
        }
    }
}