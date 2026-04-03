using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.VehicleRentalSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== VEHICLE RENTAL SYSTEM ===");
            Console.WriteLine();

            // create different vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("CAR001", 1000, 4));
            vehicles.Add(new Bike("BIKE001", 300, 150));
            vehicles.Add(new Truck("TRUCK001", 2000, 5.5));

            int rentalDays = 3;

            Console.WriteLine("=== RENTAL CALCULATIONS ===");
            foreach (Vehicle v in vehicles)
            {
                v.ShowVehicleInfo();
                double rentalCost = v.CalculateRentalCost(rentalDays);
                Console.WriteLine("Rental Cost (" + rentalDays + " days): $" + rentalCost);

                if (v is IInsurable)
                {
                    IInsurable insurable = (IInsurable)v;
                    double insurance = insurable.CalculateInsurance();
                    Console.WriteLine("Insurance: $" + insurance);
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}