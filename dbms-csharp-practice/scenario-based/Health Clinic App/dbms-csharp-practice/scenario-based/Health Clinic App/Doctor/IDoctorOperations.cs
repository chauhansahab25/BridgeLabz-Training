using System;

namespace HealthClinicApp
{
    public interface IDoctorOperations
    {
        void AddDoctorProfile();
        void AssignUpdateDoctorSpecialty();
        void ViewDoctorsBySpecialty();
        void DeactivateDoctorProfile();
    }
}
