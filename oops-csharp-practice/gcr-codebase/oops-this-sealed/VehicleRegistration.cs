using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Vehicle
    {
        static double RegistrationFee = 500.0;  // fee for all vehicles

        readonly string RegistrationNumber;  // reg no wont change
        
        string OwnerName;
        string VehicleType;

        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;                      // this to avoid name clash
            this.VehicleType = VehicleType;                  
            this.RegistrationNumber = RegistrationNumber;    
        }

        static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("fee updated to: $" + RegistrationFee);
        }

        void showVehicle()
        {
            Console.WriteLine("owner: " + OwnerName);
            Console.WriteLine("type: " + VehicleType);
            Console.WriteLine("reg no: " + RegistrationNumber);
            Console.WriteLine("fee: $" + RegistrationFee);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle v1 = new Vehicle("john", "car", "ABC123");
            Vehicle v2 = new Vehicle("alice", "bike", "XYZ789");

            object obj = v1;
            if (obj is Vehicle)  // check vehicle type
            {
                Console.WriteLine("its vehicle:");
                v1.showVehicle();
            }

            v2.showVehicle();

            Vehicle.UpdateRegistrationFee(600.0);
            
            Console.WriteLine("after fee change:");
            v1.showVehicle();

            Console.ReadLine();
        }
    }
}