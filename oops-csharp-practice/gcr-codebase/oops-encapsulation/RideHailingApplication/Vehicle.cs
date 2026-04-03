using System;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    // base vehicle class
    abstract class Vehicle : IGPS
    {
        private string vehicleId;
        private string driverName;
        private double ratePerKm;
        private string currentLocation;

        public string VehicleId { get { return vehicleId; } set { vehicleId = value; } }
        public string DriverName { get { return driverName; } set { driverName = value; } }
        public double RatePerKm { get { return ratePerKm; } set { ratePerKm = value; } }

        public Vehicle(string id, string driver, double rate)
        {
            vehicleId = id;
            driverName = driver;
            ratePerKm = rate;
            currentLocation = "Unknown";
        }

        // must be implemented by child classes
        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle: " + vehicleId + " | Driver: " + driverName);
            Console.WriteLine("Rate: $" + ratePerKm + "/km | Location: " + currentLocation);
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine("Location updated to: " + newLocation);
        }
    }
}