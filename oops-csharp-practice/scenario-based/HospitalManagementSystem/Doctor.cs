using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // doctor class
    class Doctor
    {
        private int docId;
        private string docName;
        private string specialty;
        private double consultationFee;
        private string experience;

        // properties
        public int DocId { get { return docId; } set { docId = value; } }
        public string DocName { get { return docName; } set { docName = value; } }
        public string Specialty { get { return specialty; } set { specialty = value; } }
        public double ConsultationFee { get { return consultationFee; } set { consultationFee = value; } }
        public string Experience { get { return experience; } set { experience = value; } }

        public Doctor(int id, string name, string spec, double fee, string exp)
        {
            docId = id;
            docName = name;
            specialty = spec;
            consultationFee = fee;
            experience = exp;
        }

        public void showDoctorInfo()
        {
            Console.WriteLine("ID: " + docId + " | Dr. " + docName);
            Console.WriteLine("Specialty: " + specialty);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Consultation Fee: $" + consultationFee);
            Console.WriteLine("------------------------");
        }
    }
}