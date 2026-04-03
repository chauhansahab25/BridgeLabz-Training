using System;

namespace CG_Practice.oopscsharp.VehicleRentalSystem
{
    // bike rental class
    class Bike : Vehicle, IInsurable
    {
        private int engineCC;

        public int EngineCC { get { return engineCC; } set { engineCC = value; } }

        public Bike(string number, double rate, int cc) : base(number, "Bike", rate)
        {
            engineCC = cc;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 0.8; // 20% discount for bikes
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.10; // 10% of rental rate
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance - Policy: " + PolicyNumber;
        }
    }
}