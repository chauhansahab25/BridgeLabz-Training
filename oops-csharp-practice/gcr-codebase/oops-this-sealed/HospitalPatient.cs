using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // patient class for hospital
    class Patient
    {
        // static variables - shared by all patients
        public static string HospitalName = "City Hospital";
        public static int totalPatients = 0;

        // readonly - cant change after assignment
        public readonly int PatientID;
        
        // regular variables
        public string Name;
        public int Age;
        public string Ailment;

        // constructor using this keyword
        public Patient(string Name, int Age, string Ailment, int PatientID)
        {
            this.Name = Name;            // this resolves ambiguity
            this.Age = Age;              // this resolves ambiguity
            this.Ailment = Ailment;      // this resolves ambiguity
            this.PatientID = PatientID;  // this resolves ambiguity
            totalPatients++;
        }

        // static method
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
            Console.WriteLine("Hospital: " + HospitalName);
        }

        public void showPatient()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + PatientID);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create patients
            Patient p1 = new Patient("John", 35, "Fever", 1001);
            Patient p2 = new Patient("Alice", 28, "Headache", 1002);

            // using is operator to check type
            object obj = p1;
            if (obj is Patient)
            {
                Console.WriteLine("Object is Patient - showing details:");
                p1.showPatient();
            }

            p2.showPatient();

            // call static method
            Patient.GetTotalPatients();

            Console.ReadLine();
        }
    }
}