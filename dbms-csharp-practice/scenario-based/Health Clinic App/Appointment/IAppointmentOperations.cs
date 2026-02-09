using System;

namespace HealthClinicApp
{
    public interface IAppointmentOperations
    {
        void BookNewAppointment();
        void CheckDoctorAvailability();
        void CancelAppointment();
        void RescheduleAppointment();
        void ViewDailyAppointmentSchedule();
    }
}
