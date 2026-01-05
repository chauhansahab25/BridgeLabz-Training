using System;
using System.Collections.Generic;

namespace BankingSystem
{
    // abstract bank account class
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        // properties for encapsulation
        public string AccountNumber 
        { 
            get { return accountNumber; } 
            set { accountNumber = value; } 
        }
        
        public string HolderName 
        { 
            get { return holderName; } 
            set { holderName = value; } 
        }
        
        public double Balance 
        { 
            get { return balance; } 
            private set { balance = value; }  // private setter for security
        }

        public BankAccount(string accNumber, string name, double initialBalance)
        {
            accountNumber = accNumber;
            holderName = name;
            balance = initialBalance;
        }

        // concrete methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposited: $" + amount);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawn: $" + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        // abstract method
        public abstract double CalculateInterest();

        public void DisplayAccount()
        {
            Console.WriteLine("Account: " + accountNumber);
            Console.WriteLine("Holder: " + holderName);
            Console.WriteLine("Balance: $" + balance);
        }
    }

    // interface for loan
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // savings account class
    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accNumber, string name, double balance) 
            : base(accNumber, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.04;  // 4% interest
        }

        public void ApplyForLoan(double amount)
        {
            double eligibility = CalculateLoanEligibility();
            if (amount <= eligibility)
            {
                Console.WriteLine("Loan approved: $" + amount);
            }
            else
            {
                Console.WriteLine("Loan rejected. Max eligible: $" + eligibility);
            }
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 2;  // 2x balance
        }
    }

    // current account class
    class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accNumber, string name, double balance) 
            : base(accNumber, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;  // 2% interest
        }

        public void ApplyForLoan(double amount)
        {
            double eligibility = CalculateLoanEligibility();
            if (amount <= eligibility)
            {
                Console.WriteLine("Business loan approved: $" + amount);
            }
            else
            {
                Console.WriteLine("Loan rejected. Max eligible: $" + eligibility);
            }
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 3;  // 3x balance for business
        }
    }

    class Program
    {
        static void Main()
        {
            // create different account types
            List<BankAccount> accounts = new List<BankAccount>();
            
            accounts.Add(new SavingsAccount("SAV001", "john", 10000));
            accounts.Add(new CurrentAccount("CUR001", "alice", 15000));

            Console.WriteLine("Banking System");
            Console.WriteLine("==============");

            // process all accounts using polymorphism
            foreach (BankAccount account in accounts)
            {
                account.DisplayAccount();
                
                // calculate interest polymorphically
                double interest = account.CalculateInterest();
                Console.WriteLine("Interest: $" + interest);

                // check loan eligibility
                if (account is ILoanable)
                {
                    ILoanable loanAccount = (ILoanable)account;
                    Console.WriteLine("Loan Eligibility: $" + loanAccount.CalculateLoanEligibility());
                    loanAccount.ApplyForLoan(20000);  // try to apply for loan
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}