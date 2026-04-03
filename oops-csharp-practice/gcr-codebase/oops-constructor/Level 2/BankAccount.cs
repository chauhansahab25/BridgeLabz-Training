using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // bank account class
    class BankAccount
    {
        public string accountNumber;        // everyone can see
        protected string accountHolder;     // only this class and child classes
        private double balance;             // only this class

        public BankAccount(string accNum, string holder, double bal)
        {
            accountNumber = accNum;
            accountHolder = holder;
            balance = bal;
        }

        // get balance amount
        public double getBalance()
        {
            return balance;
        }

        // add money to account
        public void deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposited $" + amount + ". New balance: $" + balance);
        }

        // take money from account
        public void withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrew $" + amount + ". New balance: $" + balance);
            }
            else
            {
                Console.WriteLine("Not enough money!");
            }
        }

        public void showAccount()
        {
            Console.WriteLine("Account: " + accountNumber);
            Console.WriteLine("Holder: " + accountHolder);
            Console.WriteLine("Balance: $" + balance);
        }
    }

    // savings account inherits from bank account
    class SavingsAccount : BankAccount
    {
        public double interestRate;

        public SavingsAccount(string accNum, string holder, double bal, double rate) 
            : base(accNum, holder, bal)
        {
            interestRate = rate;
        }

        // calculate interest
        public void addInterest()
        {
            double interest = getBalance() * interestRate / 100;
            deposit(interest);
            Console.WriteLine("Interest added: $" + interest);
        }

        public void showSavingsDetails()
        {
            Console.WriteLine("Savings Account Info:");
            Console.WriteLine("Account: " + accountNumber);      // public - can access
            Console.WriteLine("Holder: " + accountHolder);       // protected - can access
            Console.WriteLine("Balance: $" + getBalance());      // private - need method
            Console.WriteLine("Interest Rate: " + interestRate + "%");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount acc1 = new BankAccount("12345", "John", 1000.0);
            acc1.showAccount();
            Console.WriteLine();

            acc1.deposit(500);
            acc1.withdraw(200);
            Console.WriteLine();

            SavingsAccount savings1 = new SavingsAccount("67890", "Alice", 2000.0, 5.0);
            savings1.showSavingsDetails();
            savings1.addInterest();

            Console.ReadLine();
        }
    }
}