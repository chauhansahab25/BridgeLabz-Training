using System;
using System.Collections.Generic;

namespace RideHailing
{
    // abstract vehicle class
    abstract class Vehicle
    {
        private string vehicleId;
        private string driverName;
        private double ratePerKm;

        // properties for encapsulation
        public string VehicleId 
        { 
            get { return vehicleId; } 
            set { vehicleId = value; } 
        }
        
        public string DriverName 
        { 
            get { return driverName; } 
            set { driverName = value; } 
        }
        
        public double RatePerKm 
        { 
            get { return ratePerKm; } 
            set { ratePerKm = value; } 
        }

        public Vehicle(string id, string driver, double rate)
        {
            vehicleId = id;
            driverName = driver;
            ratePerKm = rate;
        }

        // abstract method
        public abstract double CalculateFare(double distance);

        // concrete method
        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID: " + vehicleId);
            Console.WriteLine("Driver: " + driverName);
            Console.WriteLine("Rate: $" + ratePerKm + "/km");
        }
    }

    // interface for GPS
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    // car class
    class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(string id, string driver, double rate) 
            : base(id, driver, rate)
        {
            currentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance + 2.0;  // base fare $2
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine("Car location updated to: " + newLocation);
        }
    }

    // bike class
    class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(string id, string driver, double rate) 
            : base(id, driver, rate)
        {
            currentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance + 1.0;  // base fare $1
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine("Bike location updated to: " + newLocation);
        }
    }

    // auto class
    class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(string id, string driver, double rate) 
            : base(id, driver, rate)
        {
            currentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance + 1.5;  // base fare $1.5
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine("Auto location updated to: " + newLocation);
        }
    }

    class Program
    {
        // method to process vehicles polymorphically
        static void ProcessRide(Vehicle vehicle, double distance)
        {
            vehicle.GetVehicleDetails();
            
            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine("Distance: " + distance + " km");
            Console.WriteLine("Fare: $" + fare);

            // update GPS location
            if (vehicle is IGPS)
            {
                IGPS gpsVehicle = (IGPS)vehicle;
                gpsVehicle.UpdateLocation("Downtown");
                Console.WriteLine("Current Location: " + gpsVehicle.GetCurrentLocation());
            }
        }

        static void Main()
        {
            // create different vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            
            vehicles.Add(new Car("CAR001", "john", 2.5));
            vehicles.Add(new Bike("BIKE001", "alice", 1.5));
            vehicles.Add(new Auto("AUTO001", "bob", 2.0));

            double rideDistance = 10.5;

            Console.WriteLine("Ride-Hailing Application");
            Console.WriteLine("=======================");

            // process all vehicles using polymorphism
            foreach (Vehicle vehicle in vehicles)
            {
                ProcessRide(vehicle, rideDistance);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}