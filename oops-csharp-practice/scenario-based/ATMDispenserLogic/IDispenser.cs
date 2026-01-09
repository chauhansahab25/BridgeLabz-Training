using System;

namespace CG_Practice.oopsscenario.ATMDispenserLogic
{
    // interface for dispenser operations
    interface IDispenser
    {
        void DispenseAmount(int amount);
        void SetNoteAvailability(int noteValue, bool available);
        void DisplayAvailableNotes();
    }
}