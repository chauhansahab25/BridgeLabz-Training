using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    class Program
    {
        static List<Doctor> doctors = new List<Doctor>();
        static int patientIdCounter = 1001;
        static int billIdCounter = 5001;

        static void Main()
        {
            Console.WriteLine("=== HOSPITAL MANAGEMENT SYSTEM ===");
            Console.WriteLine();

            // initialize doctors
            initializeDoctors();

            // show available doctors
            showDoctors();

            // get user input for doctor selection
            int selectedDoctorId = selectDoctor();
            Doctor selectedDoctor = getDoctorById(selectedDoctorId);

            // get patient details
            Patient patient = getPatientDetails(selectedDoctorId);

            // show patient info
            Console.WriteLine("\n=== PATIENT REGISTERED ===");
            patient.displayInfo();
            Console.WriteLine();

            // generate bill
            Bill bill = generateBill(patient, selectedDoctor);
            bill.showBill();

            // process payment
            Console.WriteLine("\nPress 'P' to process payment or any key to exit:");
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "P")
            {
                bill.processPayment();
            }

            Console.WriteLine("\nThank you for using Hospital Management System!");
            Console.ReadKey();
        }

        static void initializeDoctors()
        {
            doctors.Add(new Doctor(1, "Smith", "Cardiologist", 300, "15 years"));
            doctors.Add(new Doctor(2, "Johnson", "Neurologist", 350, "12 years"));
            doctors.Add(new Doctor(3, "Williams", "General Physician", 150, "8 years"));
            doctors.Add(new Doctor(4, "Brown", "Orthopedic", 250, "10 years"));
            doctors.Add(new Doctor(5, "Davis", "Pediatrician", 200, "6 years"));
        }

        static void showDoctors()
        {
            Console.WriteLine("=== AVAILABLE DOCTORS ===");
            foreach (Doctor doc in doctors)
            {
                doc.showDoctorInfo();
            }
        }

        static int selectDoctor()
        {
            Console.Write("Enter Doctor ID (1-5): ");
            int doctorId = int.Parse(Console.ReadLine());
            
            if (doctorId < 1 || doctorId > 5)
            {
                Console.WriteLine("Invalid Doctor ID! Selecting Dr. Williams (ID: 3)");
                return 3;
            }
            return doctorId;
        }

        static Doctor getDoctorById(int id)
        {
            foreach (Doctor doc in doctors)
            {
                if (doc.DocId == id)
                    return doc;
            }
            return doctors[2]; // default to Dr. Williams
        }

        static Patient getPatientDetails(int doctorId)
        {
            Console.WriteLine("\n=== PATIENT REGISTRATION ===");
            
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter patient age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.Write("Enter problem/symptoms: ");
            string problem = Console.ReadLine();
            
            Console.Write("Patient type (1-OutPatient, 2-InPatient): ");
            int patientType = int.Parse(Console.ReadLine());

            int patientId = patientIdCounter++;

            if (patientType == 2)
            {
                Console.Write("Enter number of days: ");
                int days = int.Parse(Console.ReadLine());
                
                Console.Write("Room type (general/private): ");
                string roomType = Console.ReadLine();
                
                double dailyCharge = roomType.ToLower() == "private" ? 200 : 100;
                
                return new InPatient(patientId, name, age, problem, doctorId, days, roomType, dailyCharge);
            }
            else
            {
                return new OutPatient(patientId, name, age, problem, doctorId, 1);
            }
        }

        static Bill generateBill(Patient patient, Doctor doctor)
        {
            double additionalCharges = 0;
            
            if (patient is InPatient)
            {
                InPatient inPatient = (InPatient)patient;
                additionalCharges = inPatient.calculateAmount();
            }

            return new Bill(billIdCounter++, patient.Id, doctor.DocId, doctor.ConsultationFee, additionalCharges);
        }
    }
}