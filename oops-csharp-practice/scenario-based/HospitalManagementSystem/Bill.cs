using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // bill class
    class Bill : IPayable
    {
        private int billNo;
        private int patientId;
        private int doctorId;
        private double consultationFee;
        private double additionalCharges;
        private bool paid;

        public int BillNo { get { return billNo; } set { billNo = value; } }
        public int PatientId { get { return patientId; } set { patientId = value; } }
        public int DoctorId { get { return doctorId; } set { doctorId = value; } }
        public double ConsultationFee { get { return consultationFee; } set { consultationFee = value; } }
        public double AdditionalCharges { get { return additionalCharges; } set { additionalCharges = value; } }
        public bool Paid { get { return paid; } set { paid = value; } }

        public Bill(int billNumber, int pId, int dId, double docFee, double extraCharges)
        {
            billNo = billNumber;
            patientId = pId;
            doctorId = dId;
            consultationFee = docFee;
            additionalCharges = extraCharges;
            paid = false;
        }

        public double calculateAmount()
        {
            return consultationFee + additionalCharges;
        }

        public void processPayment()
        {
            paid = true;
            Console.WriteLine("Payment processed successfully!");
            Console.WriteLine("Total amount paid: $" + calculateAmount());
        }

        public void showBill()
        {
            Console.WriteLine("========== BILL ==========");
            Console.WriteLine("Bill No: " + billNo);
            Console.WriteLine("Patient ID: " + patientId);
            Console.WriteLine("Doctor ID: " + doctorId);
            Console.WriteLine("Consultation Fee: $" + consultationFee);
            Console.WriteLine("Additional Charges: $" + additionalCharges);
            Console.WriteLine("Total Amount: $" + calculateAmount());
            Console.WriteLine("Status: " + (paid ? "Paid" : "Pending"));
            Console.WriteLine("==========================");
        }
    }
}