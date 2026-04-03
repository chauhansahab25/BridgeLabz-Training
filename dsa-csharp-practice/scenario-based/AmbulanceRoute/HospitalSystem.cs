// using System;

// public class HospitalSystem
// {
//     public static void Main(string[] args)
//     {
//         IHospitalNavigation ambulanceRoute = new AmbulanceRouteManager();

//         // 1. Setup Circular Route
//         ambulanceRoute.AddUnit("Emergency (Dr. Lovis)");
//         ambulanceRoute.AddUnit("Radiology (Dr. Risita)");
//         ambulanceRoute.AddUnit("Surgery (Dr. Ramaa)");
//         ambulanceRoute.AddUnit("ICU (Dr. Priyansu)");

//         ambulanceRoute.DisplayRoute();
//         Console.WriteLine();

//         // 2. Simulate Scenario: Emergency and Radiology are busy
//         Console.WriteLine("--- Emergency Scenario ---");
//         ambulanceRoute.SetAvailability("Emergency (Dr. Lovis)", false);
//         ambulanceRoute.SetAvailability("Radiology (Dr. Risita)", false);

//         string destination = ambulanceRoute.FindNextAvailable("Emergency (Dr. Lovis)");
//         Console.WriteLine(destination);
//         Console.WriteLine();

//         // 3. Maintenance: Surgery unit (Dr. Ramaa) closed for repairs
//         ambulanceRoute.RemoveUnit("Surgery (Dr. Ramaa)");
//         ambulanceRoute.DisplayRoute();

//         // 4. Final redirect check
//         Console.WriteLine("\nAmbulance checking again...");
//         Console.WriteLine(ambulanceRoute.FindNextAvailable("Emergency (Dr. Lovis)"));
//     }
// }