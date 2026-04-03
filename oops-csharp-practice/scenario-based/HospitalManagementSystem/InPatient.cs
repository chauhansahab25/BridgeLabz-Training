using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // inpatient class
    class InPatient : Patient, IPayable
    {
        private int days;
        private string roomType;
        private double perDayCharge;

        public int Days { get { return days; } set { days = value; } }
        public string RoomType { get { return roomType; } set { roomType = value; } }
        public double PerDayCharge { get { return perDayCharge; } set { perDayCharge = value; } }

        public InPatient(int id, string name, int age, string problem, int doctorId, int stayDays, string room, double dailyCharge) 
            : base(id, name, age, problem, doctorId)
        {
            days = stayDays;
            roomType = room;
            perDayCharge = dailyCharge;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Type: In-Patient");
            Console.WriteLine("Days: " + days);
            Console.WriteLine("Room: " + roomType);
            Console.WriteLine("Per Day Charge: $" + perDayCharge);
        }

        public double calculateAmount()
        {
            return days * perDayCharge;
        }

        public void processPayment()
        {
            Console.WriteLine("In-Patient payment processing...");
            Console.WriteLine("Room charges: $" + calculateAmount());
        }
    }
}