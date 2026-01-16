using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.TrafficManager
{
    public class TrafficManagerUtil
    {
        private class CircularNode
        {
            public Vehicle Vehicle { get; set; }
            public CircularNode Next { get; set; }

            public CircularNode(Vehicle vehicle)
            {
                Vehicle = vehicle;
                Next = null;
            }
        }

        private CircularNode head;
        private int roundaboutCapacity;
        private int currentVehicleCount;
        private Queue<Vehicle> waitingQueue;
        private const int MAX_QUEUE_SIZE = 10;

        public TrafficManagerUtil(int capacity)
        {
            roundaboutCapacity = capacity;
            currentVehicleCount = 0;
            head = null;
            waitingQueue = new Queue<Vehicle>();
        }

        // ...existing code...
        public bool AddVehicleToRoundabout(Vehicle vehicle)
        {
            if (currentVehicleCount >= roundaboutCapacity)
            {
                if (waitingQueue.Count < MAX_QUEUE_SIZE)
                {
                    waitingQueue.Enqueue(vehicle);
                    Console.WriteLine($"✓ Vehicle {vehicle.GetLicensePlate()} added to waiting queue.");
                    return true;
                }
                else
                {
                    Console.WriteLine("✗ Queue overflow! Cannot add vehicle.");
                    return false;
                }
            }

            CircularNode newNode = new CircularNode(vehicle);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                CircularNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }

            currentVehicleCount++;
            Console.WriteLine($"✓ Vehicle {vehicle.GetLicensePlate()} entered the roundabout.");
            return true;
        }

        public bool RemoveVehicleFromRoundabout()
        {
            if (head == null)
            {
                Console.WriteLine("✗ Roundabout underflow! No vehicles to remove.");
                return false;
            }

            if (head.Next == head)
            {
                Console.WriteLine($"✓ Vehicle {head.Vehicle.GetLicensePlate()} exited the roundabout.");
                head = null;
                currentVehicleCount--;
            }
            else
            {
                CircularNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }

                Console.WriteLine($"✓ Vehicle {head.Vehicle.GetLicensePlate()} exited the roundabout.");
                head = head.Next;
                temp.Next = head;
                currentVehicleCount--;
            }

            if (waitingQueue.Count > 0 && currentVehicleCount < roundaboutCapacity)
            {
                Vehicle waitingVehicle = waitingQueue.Dequeue();
                AddVehicleToRoundabout(waitingVehicle);
            }

            return true;
        }

        public void DisplayRoundaboutState()
        {
            Console.WriteLine("\n════════════════════════════════════════");
            Console.WriteLine("       ROUNDABOUT STATE REPORT");
            Console.WriteLine("════════════════════════════════════════");
            Console.WriteLine($"Capacity: {roundaboutCapacity} | Current Vehicles: {currentVehicleCount}");
            Console.WriteLine($"Waiting in Queue: {waitingQueue.Count}/{MAX_QUEUE_SIZE}\n");

            if (head == null)
            {
                Console.WriteLine("No vehicles in roundabout.");
            }
            else
            {
                Console.WriteLine("--- Vehicles in Roundabout ---");
                CircularNode temp = head;
                int position = 1;
                do
                {
                    Console.Write($"Position {position}: ");
                    temp.Vehicle.DisplayInfo();
                    temp = temp.Next;
                    position++;
                } while (temp != head);
            }

            if (waitingQueue.Count > 0)
            {
                Console.WriteLine("\n--- Vehicles Waiting ---");
                int qPosition = 1;
                foreach (Vehicle v in waitingQueue)
                {
                    Console.Write($"Queue {qPosition}: ");
                    v.DisplayInfo();
                    qPosition++;
                }
            }

            Console.WriteLine("════════════════════════════════════════\n");
        }

        public int GetCurrentVehicleCount()
        {
            return currentVehicleCount;
        }

        public int GetWaitingVehicleCount()
        {
            return waitingQueue.Count;
        }
    }
}