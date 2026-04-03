using System;

namespace CG_Practice.oopsscenario.TrafficManager
{
    class TrafficManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║    SMART CITY TRAFFIC MANAGER SYSTEM      ║");
            Console.WriteLine("║         Roundabout Vehicle Flow           ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝\n");

            TrafficManagerUtil manager = new TrafficManagerUtil(capacity: 5);
            Menu menu = new Menu(manager);

            menu.DisplayMenu();
        }
    }
}