using System;

namespace HealthClinicApp
{
    public class ClinicException : Exception
    {
        public ClinicException(string message) : base(message)
        {
        }
    }
}
