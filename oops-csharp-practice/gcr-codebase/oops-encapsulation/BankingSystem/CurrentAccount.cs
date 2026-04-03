using System;

namespace CG_Practice.oopscsharp.BankingSystem
{
    // current account class
    class CurrentAccount : BankAccount, ILoanable
    {
        private double overdraftLimit;

        public double OverdraftLimit { get { return overdraftLimit; } set { overdraftLimit = value; } }

        public CurrentAccount(string accNum, string name, double balance, double limit) : base(accNum, name, balance)
        {
            overdraftLimit = limit;
        }

        public override double CalculateInterest()
        {
            return 0; // no interest for current accounts
        }

        public void ApplyForLoan(double amount)
        {
            double eligibility = CalculateLoanEligibility();
            if (amount <= eligibility)
            {
                Console.WriteLine("Business loan approved for $" + amount);
            }
            else
            {
                Console.WriteLine("Loan rejected. Max eligible: $" + eligibility);
            }
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 3; // higher loan eligibility for business
        }
    }
}