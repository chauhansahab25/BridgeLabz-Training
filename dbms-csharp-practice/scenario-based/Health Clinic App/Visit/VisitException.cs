using System;

namespace HealthClinicApp
{
    public class VisitException : Exception
    {
        public VisitException(string message) : base(message)
        {
        }
    }
}
