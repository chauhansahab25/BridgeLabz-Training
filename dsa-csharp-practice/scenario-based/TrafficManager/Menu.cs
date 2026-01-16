using System;

namespace CG_Practice.oopsscenario.TrafficManager
{
    public class Menu
    {
        private TrafficManagerUtil manager;
        private int vehicleCounter;

        public Menu(TrafficManagerUtil managerUtil)
        {
            manager = managerUtil;
            vehicleCounter = 1;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n╔════════════════════════════════════════╗");
                Console.WriteLine("║       TRAFFIC MANAGER MENU             ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine("1. Add Vehicle to Roundabout");
                Console.WriteLine("2. Remove Vehicle from Roundabout");
                Console.WriteLine("3. Display Roundabout State");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddVehicleOption();
                        break;
                    case "2":
                        RemoveVehicleOption();
                        break;
                    case "3":
                        manager.DisplayRoundaboutState();
                        break;
                    case "4":
                        Console.WriteLine("\nExiting Traffic Manager. Safe travels!");
                        return;
                    default:
                        Console.WriteLine("✗ Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void AddVehicleOption()
        {
            Console.Write("\nEnter vehicle type (Car/Truck/Bike): ");
            string type = Console.ReadLine();

            Console.Write("Enter license plate: ");
            string plate = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(plate))
            {
                Console.WriteLine("✗ Invalid input. Please try again.");
                return;
            }

            Vehicle vehicle = new Vehicle(vehicleCounter++, type, plate);
            manager.AddVehicleToRoundabout(vehicle);
        }

        private void RemoveVehicleOption()
        {
            manager.RemoveVehicleFromRoundabout();
        }
    }
}