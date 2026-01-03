using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // patient class
    class Patient
    {
        public string Name;
        public int Age;
        public string Problem;

        public Patient(string name, int age, string problem)
        {
            Name = name;
            Age = age;
            Problem = problem;
        }

        public void showPatient()
        {
            Console.WriteLine("Patient: " + Name + ", Age: " + Age + ", Problem: " + Problem);
        }
    }

    // doctor class
    class Doctor
    {
        public string Name;
        public string Specialization;
        public List<Patient> patients;  // patients doctor treats

        public Doctor(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
            patients = new List<Patient>();
        }

        // consult with patient (communication)
        public void Consult(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine("Dr. " + Name + " consulting with " + patient.Name);
            Console.WriteLine("Diagnosis for " + patient.Problem + " in progress...");
            Console.WriteLine();
        }

        public void showPatients()
        {
            Console.WriteLine("Dr. " + Name + "'s patients:");
            foreach (Patient patient in patients)
            {
                Console.WriteLine("- " + patient.Name);
            }
            Console.WriteLine();
        }
    }

    // hospital class
    class Hospital
    {
        public string HospitalName;
        public List<Doctor> doctors;
        public List<Patient> patients;

        public Hospital(string name)
        {
            HospitalName = name;
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        // add doctor to hospital
        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            Console.WriteLine("Dr. " + doctor.Name + " joined " + HospitalName);
        }

        // admit patient
        public void admitPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine(patient.Name + " admitted to " + HospitalName);
        }

        public void showHospitalInfo()
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Doctors: " + doctors.Count);
            Console.WriteLine("Patients: " + patients.Count);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create hospital
            Hospital hospital = new Hospital("City Hospital");

            // create doctors
            Doctor doc1 = new Doctor("Smith", "Cardiology");
            Doctor doc2 = new Doctor("Jones", "General Medicine");

            // add doctors to hospital
            hospital.addDoctor(doc1);
            hospital.addDoctor(doc2);

            // create patients
            Patient p1 = new Patient("john", 45, "heart problem");
            Patient p2 = new Patient("alice", 30, "fever");
            Patient p3 = new Patient("bob", 50, "chest pain");

            // admit patients
            hospital.admitPatient(p1);
            hospital.admitPatient(p2);
            hospital.admitPatient(p3);

            // doctors consult patients (association & communication)
            doc1.Consult(p1);  // cardiologist treats heart problem
            doc1.Consult(p3);  // cardiologist treats chest pain
            doc2.Consult(p2);  // general doctor treats fever

            // show hospital info
            hospital.showHospitalInfo();
            doc1.showPatients();
            doc2.showPatients();

            Console.ReadLine();
        }
    }
}