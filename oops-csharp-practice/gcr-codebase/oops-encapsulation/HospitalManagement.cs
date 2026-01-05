using System;
using System.Collections.Generic;

namespace HospitalManagement
{
    // abstract patient class
    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;  // private sensitive data

        // properties for encapsulation
        public int PatientId 
        { 
            get { return patientId; } 
            set { patientId = value; } 
        }
        
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        
        public int Age 
        { 
            get { return age; } 
            set { age = value; } 
        }

        // protected property for diagnosis (accessible to subclasses)
        protected string Diagnosis 
        { 
            get { return diagnosis; } 
            set { diagnosis = value; } 
        }

        public Patient(int id, string patientName, int patientAge)
        {
            patientId = id;
            name = patientName;
            age = patientAge;
        }

        // abstract method
        public abstract double CalculateBill();

        // concrete method
        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + patientId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // interface for medical records
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // in-patient class
    class InPatient : Patient, IMedicalRecord
    {
        private int daysAdmitted;
        private List<string> medicalRecords;

        public InPatient(int id, string name, int age, int days) 
            : base(id, name, age)
        {
            daysAdmitted = days;
            medicalRecords = new List<string>();
            Diagnosis = "Requires hospitalization";
        }

        public override double CalculateBill()
        {
            return daysAdmitted * 500;  // $500 per day
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
            Console.WriteLine("Medical record added for in-patient");
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in medicalRecords)
            {
                Console.WriteLine("- " + record);
            }
        }
    }

    // out-patient class
    class OutPatient : Patient, IMedicalRecord
    {
        private int consultations;
        private List<string> medicalRecords;

        public OutPatient(int id, string name, int age, int visits) 
            : base(id, name, age)
        {
            consultations = visits;
            medicalRecords = new List<string>();
            Diagnosis = "Regular checkup";
        }

        public override double CalculateBill()
        {
            return consultations * 100;  // $100 per consultation
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
            Console.WriteLine("Medical record added for out-patient");
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in medicalRecords)
            {
                Console.WriteLine("- " + record);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // create different patient types
            List<Patient> patients = new List<Patient>();
            
            patients.Add(new InPatient(1, "john", 45, 5));
            patients.Add(new OutPatient(2, "alice", 30, 3));

            Console.WriteLine("Hospital Patient Management");
            Console.WriteLine("==========================");

            // process all patients using polymorphism
            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                
                // calculate bill polymorphically
                double bill = patient.CalculateBill();
                Console.WriteLine("Bill Amount: $" + bill);

                // add medical records
                if (patient is IMedicalRecord)
                {
                    IMedicalRecord recordPatient = (IMedicalRecord)patient;
                    recordPatient.AddRecord("Blood test completed");
                    recordPatient.AddRecord("X-ray taken");
                    recordPatient.ViewRecords();
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}