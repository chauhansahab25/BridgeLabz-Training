using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Patient
    {
        static string HospitalName = "city hospital";  // hospital name for all
        static int totalPatients = 0;

        readonly int PatientID;  // patient id cant change
        
        string Name;
        int Age;
        string Ailment;

        public Patient(string Name, int Age, string Ailment, int PatientID)
        {
            this.Name = Name;            // this to resolve confusion
            this.Age = Age;              
            this.Ailment = Ailment;      
            this.PatientID = PatientID;  
            totalPatients++;
        }

        static void GetTotalPatients()
        {
            Console.WriteLine("total patients: " + totalPatients);
            Console.WriteLine("hospital: " + HospitalName);
        }

        void showPatient()
        {
            Console.WriteLine("patient: " + Name);
            Console.WriteLine("id: " + PatientID);
            Console.WriteLine("age: " + Age);
            Console.WriteLine("problem: " + Ailment);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Patient p1 = new Patient("john", 35, "fever", 1001);
            Patient p2 = new Patient("alice", 28, "headache", 1002);

            object obj = p1;
            if (obj is Patient)  // check if patient type
            {
                Console.WriteLine("its patient:");
                p1.showPatient();
            }

            p2.showPatient();
            Patient.GetTotalPatients();

            Console.ReadLine();
        }
    }
}