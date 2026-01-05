using System;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    // bike class for ride hailing
    class Bike : Vehicle
    {
        private bool hasHelmet;

        public bool HasHelmet { get { return hasHelmet; } set { hasHelmet = value; } }

        public Bike(string id, string driver, double rate, bool helmet) : base(id, driver, rate)
        {
            hasHelmet = helmet;
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.7; // 30% cheaper than cars
        }
    }
}