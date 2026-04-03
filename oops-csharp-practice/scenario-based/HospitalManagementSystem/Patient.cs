using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // base patient class
    class Patient
    {
        private int id;
        private string patientName;
        private int patientAge;
        private string problem;
        private int selectedDoctorId;

        // properties
        public int Id { get { return id; } set { id = value; } }
        public string PatientName { get { return patientName; } set { patientName = value; } }
        public int PatientAge { get { return patientAge; } set { patientAge = value; } }
        public string Problem { get { return problem; } set { problem = value; } }
        public int SelectedDoctorId { get { return selectedDoctorId; } set { selectedDoctorId = value; } }

        public Patient(int patientId, string name, int age, string diagnosis, int doctorId)
        {
            id = patientId;
            patientName = name;
            patientAge = age;
            problem = diagnosis;
            selectedDoctorId = doctorId;
        }

        // can be overridden by child classes
        public virtual void displayInfo()
        {
            Console.WriteLine("Patient ID: " + id);
            Console.WriteLine("Name: " + patientName);
            Console.WriteLine("Age: " + patientAge);
            Console.WriteLine("Problem: " + problem);
            Console.WriteLine("Doctor ID: " + selectedDoctorId);
        }
    }
}