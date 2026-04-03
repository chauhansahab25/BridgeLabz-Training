using System;

namespace HealthClinicApp
{
    public class AppointmentException : Exception
    {
        public AppointmentException(string message) : base(message)
        {
        }
    }
}
