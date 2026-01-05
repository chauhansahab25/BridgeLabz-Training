using System;
using System.Collections.Generic;

namespace VehicleRental
{
    // abstract vehicle class
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        // properties for encapsulation
        public string VehicleNumber 
        { 
            get { return vehicleNumber; } 
            set { vehicleNumber = value; } 
        }
        
        public string Type 
        { 
            get { return type; } 
            set { type = value; } 
        }
        
        public double RentalRate 
        { 
            get { return rentalRate; } 
            set { rentalRate = value; } 
        }

        public Vehicle(string number, string vehicleType, double rate)
        {
            vehicleNumber = number;
            type = vehicleType;
            rentalRate = rate;
        }

        // abstract method
        public abstract double CalculateRentalCost(int days);

        public void DisplayVehicle()
        {
            Console.WriteLine("Vehicle: " + type + " (" + vehicleNumber + ")");
            Console.WriteLine("Rate: $" + rentalRate + "/day");
        }
    }

    // interface for insurance
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // car class
    class Car : Vehicle, IInsurable
    {
        private string policyNumber;

        public Car(string number, double rate) 
            : base(number, "Car", rate)
        {
            policyNumber = "POL" + number;  // generate policy number
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.1;  // 10% of rental rate
        }

        public string GetInsuranceDetails()
        {
            return "Policy: " + policyNumber + " (Car Insurance)";
        }
    }

    // bike class
    class Bike : Vehicle, IInsurable
    {
        private string policyNumber;

        public Bike(string number, double rate) 
            : base(number, "Bike", rate)
        {
            policyNumber = "POL" + number;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 0.8;  // 20% discount for bikes
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.05;  // 5% of rental rate
        }

        public string GetInsuranceDetails()
        {
            return "Policy: " + policyNumber + " (Bike Insurance)";
        }
    }

    // truck class
    class Truck : Vehicle, IInsurable
    {
        private string policyNumber;

        public Truck(string number, double rate) 
            : base(number, "Truck", rate)
        {
            policyNumber = "POL" + number;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 1.5;  // 50% extra for trucks
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.2;  // 20% of rental rate
        }

        public string GetInsuranceDetails()
        {
            return "Policy: " + policyNumber + " (Truck Insurance)";
        }
    }

    class Program
    {
        static void Main()
        {
            // create different vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            
            vehicles.Add(new Car("CAR001", 100));
            vehicles.Add(new Bike("BIKE001", 50));
            vehicles.Add(new Truck("TRUCK001", 200));

            int rentalDays = 3;

            Console.WriteLine("Vehicle Rental System");
            Console.WriteLine("====================");

            // process all vehicles using polymorphism
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayVehicle();
                
                double rentalCost = vehicle.CalculateRentalCost(rentalDays);
                Console.WriteLine("Rental Cost (" + rentalDays + " days): $" + rentalCost);

                // check if insurable
                if (vehicle is IInsurable)
                {
                    IInsurable insurableVehicle = (IInsurable)vehicle;
                    double insurance = insurableVehicle.CalculateInsurance();
                    Console.WriteLine("Insurance: $" + insurance);
                    Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}