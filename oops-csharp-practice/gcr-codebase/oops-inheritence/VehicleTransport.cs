using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base vehicle class
    class Vehicle
    {
        public int MaxSpeed;     // max speed of vehicle
        public string FuelType;  // fuel type

        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        // virtual method for displaying info
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }

    // car class inherits from vehicle
    class Car : Vehicle
    {
        public int SeatCapacity;  // additional attribute

        public Car(int maxSpeed, string fuelType, int seatCapacity) 
            : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Car");
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Seat Capacity: " + SeatCapacity);
        }
    }

    // truck class inherits from vehicle
    class Truck : Vehicle
    {
        public int PayloadCapacity;  // additional attribute

        public Truck(int maxSpeed, string fuelType, int payloadCapacity) 
            : base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Truck");
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity: " + PayloadCapacity + " tons");
        }
    }

    // motorcycle class inherits from vehicle
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;  // additional attribute

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) 
            : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Motorcycle");
            base.DisplayInfo();
            Console.WriteLine("Has Sidecar: " + (HasSidecar ? "Yes" : "No"));
        }
    }

    class Program
    {
        static void Main()
        {
            // create different vehicles
            Car car = new Car(180, "Petrol", 5);
            Truck truck = new Truck(120, "Diesel", 10);
            Motorcycle bike = new Motorcycle(200, "Petrol", false);

            // display individual vehicle info
            car.DisplayInfo();
            Console.WriteLine();

            truck.DisplayInfo();
            Console.WriteLine();

            bike.DisplayInfo();
            Console.WriteLine();

            // polymorphism - store different vehicles in vehicle array
            Vehicle[] vehicles = { car, truck, bike };
            
            Console.WriteLine("All Vehicles (Polymorphism):");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();  // dynamic method dispatch
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }
    }
}