using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.ATMDispenserLogic
{
        class ATMDispenser : IDispenser
        {
            private int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            private bool[] noteAvailable = { true, true, true, true, true, true, true, true, true };

            public void DispenseAmount(int amount)
            {
                Console.WriteLine("Dispensing ₹" + amount);
                int[] noteCount = new int[notes.Length];
                int remainingAmount = amount;
                bool canDispense = true;

                for (int i = 0; i < notes.Length; i++)
                {
                    if (noteAvailable[i] && remainingAmount >= notes[i])
                    {
                        noteCount[i] = remainingAmount / notes[i];
                        remainingAmount = remainingAmount % notes[i];
                    }
                }

                if (remainingAmount > 0)
                {
                    canDispense = false;
                    Console.WriteLine("Exact change not possible. Fallback combination:");
                    DisplayFallbackCombo(amount);
                }
                else
                {
                    Console.WriteLine("Optimal combination:");
                    DisplayNotes(noteCount);
                }
            }

            public void SetNoteAvailability(int noteValue, bool available)
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i] == noteValue)
                    {
                        noteAvailable[i] = available;
                        Console.WriteLine("₹" + noteValue + " notes " + (available ? "enabled" : "disabled"));
                        break;
                    }
                }
            }

            private void DisplayNotes(int[] noteCount)
            {
                int totalNotes = 0;
                for (int i = 0; i < notes.Length; i++)
                {
                    if (noteCount[i] > 0)
                    {
                        Console.WriteLine("₹" + notes[i] + " x " + noteCount[i] + " = ₹" + (notes[i] * noteCount[i]));
                        totalNotes += noteCount[i];
                    }
                }
                Console.WriteLine("Total notes: " + totalNotes);
            }

            private void DisplayFallbackCombo(int amount)
            {
                // Try to get closest possible amount
                int closestAmount = GetClosestPossibleAmount(amount);
                if (closestAmount > 0)
                {
                    Console.WriteLine("Dispensing ₹" + closestAmount + " instead of ₹" + amount);
                    DispenseAmount(closestAmount);
                }
                else
                {
                    Console.WriteLine("Cannot dispense any amount with available notes");
                }
            }

            private int GetClosestPossibleAmount(int amount)
            {
                for (int i = amount - 1; i > 0; i--)
                {
                    if (CanDispenseExact(i))
                    {
                        return i;
                    }
                }
                return 0;
            }

            private bool CanDispenseExact(int amount)
            {
                int remaining = amount;
                for (int i = 0; i < notes.Length; i++)
                {
                    if (noteAvailable[i] && remaining >= notes[i])
                    {
                        remaining = remaining % notes[i];
                    }
                }
                return remaining == 0;
            }

            public void DisplayAvailableNotes()
            {
                Console.WriteLine("Available notes:");
                for (int i = 0; i < notes.Length; i++)
                {
                    if (noteAvailable[i])
                    {
                        Console.Write("₹" + notes[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
}