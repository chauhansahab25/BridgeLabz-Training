using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // vehicle class for registration
    class Vehicle
    {
        // static variable - shared by all vehicles
        public static double RegistrationFee = 500.0;

        // readonly - cant change after assignment
        public readonly string RegistrationNumber;
        
        // regular variables
        public string OwnerName;
        public string VehicleType;

        // constructor using this keyword
        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;                      // this resolves ambiguity
            this.VehicleType = VehicleType;                  // this resolves ambiguity
            this.RegistrationNumber = RegistrationNumber;    // this resolves ambiguity
        }

        // static method
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Registration fee updated to: $" + RegistrationFee);
        }

        public void showVehicle()
        {
            Console.WriteLine("Owner: " + OwnerName);
            Console.WriteLine("Type: " + VehicleType);
            Console.WriteLine("Registration: " + RegistrationNumber);
            Console.WriteLine("Fee: $" + RegistrationFee);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create vehicles
            Vehicle v1 = new Vehicle("John", "Car", "ABC123");
            Vehicle v2 = new Vehicle("Alice", "Bike", "XYZ789");

            // using is operator to check type
            object obj = v1;
            if (obj is Vehicle)
            {
                Console.WriteLine("Object is Vehicle - showing details:");
                v1.showVehicle();
            }

            v2.showVehicle();

            // update fee using static method
            Vehicle.UpdateRegistrationFee(600.0);
            
            Console.WriteLine("After fee update:");
            v1.showVehicle();

            Console.ReadLine();
        }
    }
}