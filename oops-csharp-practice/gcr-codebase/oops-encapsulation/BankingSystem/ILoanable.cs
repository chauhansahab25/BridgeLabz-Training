using System;

namespace CG_Practice.oopscsharp.BankingSystem
{
    // interface for accounts that can get loans
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }
}