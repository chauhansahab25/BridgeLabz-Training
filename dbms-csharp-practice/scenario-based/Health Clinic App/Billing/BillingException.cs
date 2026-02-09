using System;

namespace HealthClinicApp
{
    public class BillingException : Exception
    {
        public BillingException(string message) : base(message)
        {
        }
    }
}
