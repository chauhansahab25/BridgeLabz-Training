using System;

namespace CG_Practice.oopsscenario.ATMDispenserLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("$ATM Dispenser Logic$");
            Console.WriteLine();

            ATMDispenser atm = new ATMDispenser();

            // Scenario A: All notes available, dispense ₹880
            Console.WriteLine("=== Scenario A: ===");
            atm.DisplayAvailableNotes();
            atm.DispenseAmount(880);
            Console.WriteLine();

            // Scenario B: Remove ₹500 notes and update strategy
            Console.WriteLine("=== Scenario B: ===");
            atm.SetNoteAvailability(500, false);
            atm.DisplayAvailableNotes();
            atm.DispenseAmount(880);
            Console.WriteLine();

            // Scenario C: Try amount that can't be dispensed exactly
            Console.WriteLine("=== Scenario C: ===");
            atm.DispenseAmount(883);
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}