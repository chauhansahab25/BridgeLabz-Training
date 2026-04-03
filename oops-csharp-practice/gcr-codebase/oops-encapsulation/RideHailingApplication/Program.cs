using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== RIDE HAILING APPLICATION ===");
            Console.WriteLine();

            // create different vehicle types
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("CAR001", "John Driver", 15, true));
            vehicles.Add(new Bike("BIKE001", "Mike Rider", 8, true));
            vehicles.Add(new Auto("AUTO001", "Ram Singh", 10, 3));

            double tripDistance = 12.5;

            Console.WriteLine("=== AVAILABLE RIDES ===");
            foreach (Vehicle v in vehicles)
            {
                v.UpdateLocation("Downtown");
                v.GetVehicleDetails();
                
                double fare = v.CalculateFare(tripDistance);
                Console.WriteLine("Fare for " + tripDistance + "km: $" + fare);
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}