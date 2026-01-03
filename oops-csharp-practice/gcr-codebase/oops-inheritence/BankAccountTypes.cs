using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base bank account class
    class BankAccount
    {
        public string AccountNumber;  // account number
        public double Balance;        // account balance

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Basic Bank Account");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
        }
    }

    // savings account inherits from bank account (hierarchical)
    class SavingsAccount : BankAccount
    {
        public double InterestRate;  // interest rate for savings

        public SavingsAccount(string accountNumber, double balance, double interestRate) 
            : base(accountNumber, balance)  // call parent constructor
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
            Console.WriteLine("Interest Rate: " + InterestRate + "%");
        }
    }

    // checking account inherits from bank account (hierarchical)
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;  // daily withdrawal limit

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) 
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Checking Account");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
            Console.WriteLine("Withdrawal Limit: $" + WithdrawalLimit);
        }
    }

    // fixed deposit account inherits from bank account (hierarchical)
    class FixedDepositAccount : BankAccount
    {
        public int MaturityPeriod;  // maturity period in months

        public FixedDepositAccount(string accountNumber, double balance, int maturityPeriod) 
            : base(accountNumber, balance)
        {
            MaturityPeriod = maturityPeriod;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
            Console.WriteLine("Maturity Period: " + MaturityPeriod + " months");
        }
    }

    class Program
    {
        static void Main()
        {
            // create different account types (hierarchical inheritance)
            SavingsAccount savings = new SavingsAccount("SAV001", 5000, 3.5);
            CheckingAccount checking = new CheckingAccount("CHK001", 2000, 500);
            FixedDepositAccount fd = new FixedDepositAccount("FD001", 10000, 12);

            // display account details
            Console.WriteLine("Savings Account:");
            savings.DisplayAccountType();
            Console.WriteLine();

            Console.WriteLine("Checking Account:");
            checking.DisplayAccountType();
            Console.WriteLine();

            Console.WriteLine("Fixed Deposit Account:");
            fd.DisplayAccountType();
            Console.WriteLine();

            // polymorphism with hierarchical inheritance
            BankAccount[] accounts = { savings, checking, fd };
            Console.WriteLine("All Accounts:");
            foreach (BankAccount account in accounts)
            {
                account.DisplayAccountType();
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }
    }
}