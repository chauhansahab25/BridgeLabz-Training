using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.HospitalPatientManagement
{
    // base patient class
    abstract class Patient : IMedicalRecord
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;
        private List<string> medicalHistory;

        public int PatientId { get { return patientId; } set { patientId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        protected string Diagnosis { get { return diagnosis; } set { diagnosis = value; } }

        public Patient(int id, string patientName, int patientAge)
        {
            patientId = id;
            name = patientName;
            age = patientAge;
            medicalHistory = new List<string>();
        }

        // must be implemented by child classes
        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + patientId + " | Name: " + name + " | Age: " + age);
        }

        public void AddRecord(string record)
        {
            medicalHistory.Add(record);
            Console.WriteLine("Medical record added");
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History:");
            foreach (string record in medicalHistory)
            {
                Console.WriteLine("- " + record);
            }
        }
    }
}