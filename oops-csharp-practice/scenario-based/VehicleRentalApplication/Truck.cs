using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.VehicleRentalApplication
{
      // truck rental class
        class Truck : Vehicle, IInsurable
        {
            private double loadCapacity;

            public double LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

            public Truck(string number, double rate, double capacity) : base(number, "Truck", rate)
            {
                loadCapacity = capacity;
            }

            public override double CalculateRentalCost(int days)
            {
                return RentalRate * days * 1.5; // 50% extra for trucks
            }

            public double CalculateInsurance()
            {
                return RentalRate * 0.25; // 25% of rental rate
            }

            public string GetInsuranceDetails()
            {
                return "Truck Insurance - Policy: " + PolicyNumber;
            }
        }
    
}
