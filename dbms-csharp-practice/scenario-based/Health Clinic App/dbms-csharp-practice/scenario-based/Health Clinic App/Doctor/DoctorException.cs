using System;

namespace HealthClinicApp
{
    public class DoctorException : Exception
    {
        public DoctorException(string message) : base(message)
        {
        }
    }
}
