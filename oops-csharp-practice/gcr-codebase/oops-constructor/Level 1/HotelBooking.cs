using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Hotel booking system with different constructors
    class HotelBooking
    {
        public string guestName;
        public string roomType;
        public int nights;

        // default constructor
        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        // parameterized constructor
        public HotelBooking(string guest, string room, int n)
        {
            guestName = guest;
            roomType = room;
            nights = n;
        }

        // copy constructor
        public HotelBooking(HotelBooking other)
        {
            guestName = other.guestName;
            roomType = other.roomType;
            nights = other.nights;
        }

        // show booking details
        public void displayBooking()
        {
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Nights: " + nights);
            Console.WriteLine("Total Cost: $" + (nights * 100)); // $100 per night
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // default constructor
            Console.WriteLine("Booking 1 (Default):");
            HotelBooking booking1 = new HotelBooking();
            booking1.displayBooking();

            // parameterized constructor
            Console.WriteLine("Booking 2 (Parameterized):");
            HotelBooking booking2 = new HotelBooking("Alice", "Deluxe", 3);
            booking2.displayBooking();

            // copy constructor
            Console.WriteLine("Booking 3 (Copy):");
            HotelBooking booking3 = new HotelBooking(booking2);
            booking3.displayBooking();

            Console.ReadLine();
        }
    }
}