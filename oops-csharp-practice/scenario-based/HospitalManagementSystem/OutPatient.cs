using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // outpatient class
    class OutPatient : Patient, IPayable
    {
        private int visitCount;

        public int VisitCount { get { return visitCount; } set { visitCount = value; } }

        public OutPatient(int id, string name, int age, string problem, int doctorId, int visits) 
            : base(id, name, age, problem, doctorId)
        {
            visitCount = visits;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Type: Out-Patient");
            Console.WriteLine("Visits: " + visitCount);
        }

        public double calculateAmount()
        {
            return 0; // only consultation fee for outpatients
        }

        public void processPayment()
        {
            Console.WriteLine("Out-Patient payment processing...");
            Console.WriteLine("No additional charges for outpatient");
        }
    }
}