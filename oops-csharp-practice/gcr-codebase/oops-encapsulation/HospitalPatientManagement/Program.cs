using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.HospitalPatientManagement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== HOSPITAL PATIENT MANAGEMENT ===");
            Console.WriteLine();

            // create different patient types
            List<Patient> patients = new List<Patient>();
            patients.Add(new InPatient(101, "John Smith", 45, 5, 1000));
            patients.Add(new OutPatient(102, "Sarah Johnson", 30, 3));

            Console.WriteLine("=== PATIENT BILLING ===");
            foreach (Patient p in patients)
            {
                p.GetPatientDetails();
                p.AddRecord("Blood test done");
                p.AddRecord("X-ray taken");
                
                double bill = p.CalculateBill();
                Console.WriteLine("Total Bill: $" + bill);
                
                p.ViewRecords();
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}