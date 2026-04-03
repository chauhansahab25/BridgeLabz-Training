using System;

namespace CG_Practice.oopscsharp.BankingSystem
{
    // savings account class
    class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate;

        public double InterestRate { get { return interestRate; } set { interestRate = value; } }

        public SavingsAccount(string accNum, string name, double balance, double rate) : base(accNum, name, balance)
        {
            interestRate = rate;
        }

        public override double CalculateInterest()
        {
            return Balance * interestRate / 100; // simple interest
        }

        public void ApplyForLoan(double amount)
        {
            double eligibility = CalculateLoanEligibility();
            if (amount <= eligibility)
            {
                Console.WriteLine("Loan approved for $" + amount);
            }
            else
            {
                Console.WriteLine("Loan rejected. Max eligible: $" + eligibility);
            }
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 2; // can get loan up to 2x balance
        }
    }
}