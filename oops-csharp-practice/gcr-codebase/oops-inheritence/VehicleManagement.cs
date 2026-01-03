using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base vehicle class
    class Vehicle
    {
        public int MaxSpeed;   // maximum speed
        public string Model;   // vehicle model

        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
        }
    }

    // refuelable interface - defines refueling behavior
    interface IRefuelable
    {
        void Refuel();  // method to refuel
    }

    // electric vehicle class inherits from vehicle
    class ElectricVehicle : Vehicle
    {
        public int BatteryCapacity;  // battery capacity in kWh

        public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) 
            : base(maxSpeed, model)  // call parent constructor
        {
            BatteryCapacity = batteryCapacity;
        }

        // electric vehicles charge instead of refuel
        public void Charge()
        {
            Console.WriteLine(Model + " is charging battery (" + BatteryCapacity + " kWh)");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Type: Electric Vehicle");
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " kWh");
        }
    }

    // petrol vehicle class inherits from vehicle and implements refuelable (hybrid)
    class PetrolVehicle : Vehicle, IRefuelable
    {
        public int FuelTankCapacity;  // fuel tank capacity in liters

        public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity) 
            : base(maxSpeed, model)
        {
            FuelTankCapacity = fuelTankCapacity;
        }

        // implement interface method
        public void Refuel()
        {
            Console.WriteLine(Model + " is refueling petrol tank (" + FuelTankCapacity + " liters)");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Type: Petrol Vehicle");
            Console.WriteLine("Fuel Tank Capacity: " + FuelTankCapacity + " liters");
        }
    }

    class Program
    {
        static void Main()
        {
            // create different vehicle types (hybrid inheritance)
            ElectricVehicle tesla = new ElectricVehicle(250, "Tesla Model 3", 75);
            PetrolVehicle honda = new PetrolVehicle(180, "Honda Civic", 50);

            // display vehicle information
            Console.WriteLine("Electric Vehicle:");
            tesla.DisplayInfo();
            tesla.Charge();  // electric specific method
            Console.WriteLine();

            Console.WriteLine("Petrol Vehicle:");
            honda.DisplayInfo();
            honda.Refuel();  // interface method
            Console.WriteLine();

            // polymorphism with base class
            Vehicle[] vehicles = { tesla, honda };
            Console.WriteLine("All Vehicles:");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }
    }
}