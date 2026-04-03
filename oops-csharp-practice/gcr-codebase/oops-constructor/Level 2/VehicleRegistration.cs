using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Vehicle registration system
    class Vehicle
    {
        // instance variables - different for each vehicle
        public string ownerName;
        public string vehicleType;
        
        // class variable - same registration fee for all vehicles
        public static double registrationFee = 150.00;

        // constructor
        public Vehicle(string owner, string type)
        {
            ownerName = owner;
            vehicleType = type;
        }

        // instance method - display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
            Console.WriteLine("Registration Fee: $" + registrationFee);
            Console.WriteLine();
        }

        // class method - update registration fee for all vehicles
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
            Console.WriteLine("Registration fee updated to: $" + registrationFee);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create vehicles
            Vehicle v1 = new Vehicle("John Smith", "Car");
            Vehicle v2 = new Vehicle("Alice Johnson", "Motorcycle");
            Vehicle v3 = new Vehicle("Bob Wilson", "Truck");

            // display vehicle details with current fee
            Console.WriteLine("Vehicle Details (Current Fee):");
            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();
            v3.DisplayVehicleDetails();

            // update registration fee using class method
            Vehicle.UpdateRegistrationFee(200.00);

            // display details again with updated fee
            Console.WriteLine("Vehicle Details (Updated Fee):");
            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();
            v3.DisplayVehicleDetails();

            Console.ReadLine();
        }
    }
}