using System;
using HealthClinicApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("   HEALTH CLINIC MANAGEMENT SYSTEM");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("1. Patient Management");
            Console.WriteLine("2. Doctor Management");
            Console.WriteLine("0. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ClinicMenu patientMenu = new ClinicMenu();
                patientMenu.ShowMainMenu();
            }
            else if (choice == "2")
            {
                DoctorMenu doctorMenu = new DoctorMenu();
                doctorMenu.ShowDoctorMenu();
            }
            else if (choice == "0")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid choice!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
