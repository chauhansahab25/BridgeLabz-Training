using System;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    // car class for ride hailing
    class Car : Vehicle
    {
        private bool isAC;

        public bool IsAC { get { return isAC; } set { isAC = value; } }

        public Car(string id, string driver, double rate, bool ac) : base(id, driver, rate)
        {
            isAC = ac;
        }

        public override double CalculateFare(double distance)
        {
            double baseFare = distance * RatePerKm;
            if (isAC)
            {
                baseFare += 50; // AC surcharge
            }
            return baseFare;
        }
    }
}