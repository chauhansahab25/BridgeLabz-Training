using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Car rental system
    class CarRental
    {
        public string customerName;
        public string carModel;
        public int rentalDays;
        public double dailyRate; // cost per day

        // default constructor
        public CarRental()
        {
            customerName = "Unknown";
            carModel = "Economy";
            rentalDays = 1;
            dailyRate = 50.0; // default $50 per day
        }

        // parameterized constructor
        public CarRental(string customer, string car, int days)
        {
            customerName = customer;
            carModel = car;
            rentalDays = days;
            // set rate based on car model
            if (car == "Luxury")
                dailyRate = 150.0;
            else if (car == "SUV")
                dailyRate = 100.0;
            else
                dailyRate = 50.0; // economy
        }

        // calculate total rental cost
        public double calculateTotalCost()
        {
            return rentalDays * dailyRate;
        }

        // display rental details
        public void showRentalDetails()
        {
            Console.WriteLine("Customer: " + customerName);
            Console.WriteLine("Car Model: " + carModel);
            Console.WriteLine("Rental Days: " + rentalDays);
            Console.WriteLine("Daily Rate: $" + dailyRate);
            Console.WriteLine("Total Cost: $" + calculateTotalCost());
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // default rental
            Console.WriteLine("Rental 1 (Default):");
            CarRental rental1 = new CarRental();
            rental1.showRentalDetails();

            // economy car rental
            Console.WriteLine("Rental 2 (Economy):");
            CarRental rental2 = new CarRental("Bob", "Economy", 5);
            rental2.showRentalDetails();

            // luxury car rental
            Console.WriteLine("Rental 3 (Luxury):");
            CarRental rental3 = new CarRental("Alice", "Luxury", 3);
            rental3.showRentalDetails();

            Console.ReadLine();
        }
    }
}