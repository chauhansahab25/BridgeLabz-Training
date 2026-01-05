using System;

namespace CG_Practice.oopscsharp.BankingSystem
{
    // base bank account class
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public string HolderName { get { return holderName; } set { holderName = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        public BankAccount(string accNum, string name, double initialBalance)
        {
            accountNumber = accNum;
            holderName = name;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: $" + amount + " | New Balance: $" + balance);
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: $" + amount + " | New Balance: $" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        // must be implemented by child classes
        public abstract double CalculateInterest();

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account: " + accountNumber + " | Holder: " + holderName);
            Console.WriteLine("Balance: $" + balance);
        }
    }
}