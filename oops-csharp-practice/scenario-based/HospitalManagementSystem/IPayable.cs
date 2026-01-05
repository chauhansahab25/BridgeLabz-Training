using System;

namespace CG_Practice.oopsscenario.HospitalManagementSystem
{
    // interface for things that can be paid
    interface IPayable
    {
        double calculateAmount();
        void processPayment();
    }
}