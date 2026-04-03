using System;

namespace CG_Practice.oopsscenario.SmartHomeAutomationSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Smart Home Automation System ===");
            Console.WriteLine();

            // Create appliances
            Light livingRoomLight = new Light("Living Room Light", "Living Room");
            Fan bedroomFan = new Fan("Bedroom Fan", "Bedroom");
            AC masterAC = new AC("Master AC", "Master Bedroom");

            IControllable[] appliances = { livingRoomLight, bedroomFan, masterAC };

            Console.WriteLine("Turning ON all appliances:");
            foreach (IControllable appliance in appliances)
            {
                appliance.TurnOn(); 
            }

            Console.WriteLine();
            Console.WriteLine("Current Status:");
            foreach (Appliance app in appliances)
            {
                app.DisplayStatus();
            }

            Console.WriteLine();
            Console.WriteLine("Adjusting settings:");
            livingRoomLight.SetBrightness(75);
            bedroomFan.SetSpeed(3);
            masterAC.SetTemperature(22);
            masterAC.SetMode("Auto");

            Console.WriteLine();
            Console.WriteLine("Turning OFF all appliances:");
            foreach (IControllable appliance in appliances)
            {
                appliance.TurnOff(); 
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}