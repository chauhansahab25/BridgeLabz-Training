using System;
using System.Collections.Generic;

public class PassengerNode
{
    public int SeatNumber;
    public string PassengerName;
    public PassengerNode Next;

    public PassengerNode(int seatNumber, string passengerName)
    {
        SeatNumber = seatNumber;
        PassengerName = passengerName;
        Next = null;
    }
}

public class TrainBooking
{
    private PassengerNode head;
    private Stack<int> cancelledSeats;
    private int maxSeatSoFar;

    public TrainBooking()
    {
        head = null;
        cancelledSeats = new Stack<int>();
        maxSeatSoFar = 0;
    }

    public int BookSeat(string passengerName)
    {
        int seatNumber;

        if (cancelledSeats.Count > 0)
        {
            seatNumber = cancelledSeats.Pop();
        }
        else
        {
            maxSeatSoFar++;
            seatNumber = maxSeatSoFar;
        }

        PassengerNode newPassenger =
            new PassengerNode(seatNumber, passengerName);

        // Insert at beginning
        if (head == null || seatNumber < head.SeatNumber)
        {
            newPassenger.Next = head;
            head = newPassenger;

            return seatNumber;
        }

        // Insert at correct sorted position
        PassengerNode current = head;

        while (current.Next != null &&
               current.Next.SeatNumber < seatNumber)
        {
            current = current.Next;
        }

        newPassenger.Next = current.Next;
        current.Next = newPassenger;

        return seatNumber;
    }

    public bool CancelSeat(int seatNumber)
    {
        if (head == null)
        {
            return false;
        }
        if (head.SeatNumber == seatNumber)
        {
            head = head.Next;
            cancelledSeats.Push(seatNumber);
            return true;
        }
        PassengerNode current = head;
        while (current.Next != null &&
               current.Next.SeatNumber != seatNumber)
        {
            current = current.Next;
        }
        if (current.Next == null)
        {
            return false;
        }
        current.Next = current.Next.Next;
        cancelledSeats.Push(seatNumber);
        return true;
    }
    public List<PassengerNode> GetPassengerList()
    {
        List<PassengerNode> passengers =new List<PassengerNode>();
        PassengerNode current = head;
        while (current != null)
        {
            passengers.Add(current);
            current = current.Next;
        }
        return passengers;
    }
}

class Program
{
    static void Main()
    {
        TrainBooking booking = new TrainBooking();
        int choice;
        do
        {
            Console.WriteLine("\n1. Book Seat");
            Console.WriteLine("2. Cancel Seat");
            Console.WriteLine("3. Show Passenger List");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Passenger Name: ");
                    string name = Console.ReadLine();
                    int seat = booking.BookSeat(name);
                    Console.WriteLine(
                        "Seat booked successfully."
                    );
                    Console.WriteLine(
                        "Seat Number: " + seat
                    );
                    break;
                case 2:
                    Console.Write("Enter Seat Number to cancel: ");
                    int seatNumber =
                        Convert.ToInt32(Console.ReadLine());
                    bool cancelled =
                        booking.CancelSeat(seatNumber);
                    if (cancelled)
                    {
                        Console.WriteLine(
                            "Seat cancelled successfully."
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            "Seat number not found."
                        );
                    }
                    break;
                case 3:
                    List<PassengerNode> passengers =
                        booking.GetPassengerList();
                    if (passengers.Count == 0)
                    {
                        Console.WriteLine("No passengers.");
                    }
                    else
                    {
                        Console.WriteLine("\nPassenger List:");
                        foreach (PassengerNode p in passengers)
                        {
                            Console.WriteLine(
                                "Seat: " + p.SeatNumber +
                                ", Name: " + p.PassengerName
                            );
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 4);
    }
}