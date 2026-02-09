using System;

namespace HealthClinicApp
{
    public interface IBillingOperations
    {
        void GenerateBillForVisit();
        void RecordPayment();
        void ViewOutstandingBills();
        void GenerateRevenueReport();
    }
}
