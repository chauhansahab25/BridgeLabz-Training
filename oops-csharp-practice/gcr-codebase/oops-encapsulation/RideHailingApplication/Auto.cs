using System;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    // auto rickshaw class for ride hailing
    class Auto : Vehicle
    {
        private int passengerCapacity;

        public int PassengerCapacity { get { return passengerCapacity; } set { passengerCapacity = value; } }

        public Auto(string id, string driver, double rate, int capacity) : base(id, driver, rate)
        {
            passengerCapacity = capacity;
        }

        public override double CalculateFare(double distance)
        {
            double baseFare = distance * RatePerKm;
            if (distance < 2)
            {
                baseFare += 20; // minimum fare for short distances
            }
            return baseFare;
        }
    }
}