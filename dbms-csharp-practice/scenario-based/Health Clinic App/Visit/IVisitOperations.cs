using System;

namespace HealthClinicApp
{
    public interface IVisitOperations
    {
        void RecordPatientVisit();
        void ViewPatientMedicalHistory();
        void AddPrescriptionDetails();
    }
}
