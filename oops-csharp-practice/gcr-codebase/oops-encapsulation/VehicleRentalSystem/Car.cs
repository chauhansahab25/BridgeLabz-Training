using System;

namespace CG_Practice.oopscsharp.VehicleRentalSystem
{
    // car rental class
    class Car : Vehicle, IInsurable
    {
        private int seats;

        public int Seats { get { return seats; } set { seats = value; } }

        public Car(string number, double rate, int seatCount) : base(number, "Car", rate)
        {
            seats = seatCount;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days; // basic rate for cars
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.15; // 15% of rental rate
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance - Policy: " + PolicyNumber;
        }
    }
}