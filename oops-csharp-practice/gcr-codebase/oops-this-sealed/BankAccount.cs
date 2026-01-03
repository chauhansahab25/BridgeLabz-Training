using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // bank account class
    class BankAccount
    {
        // static variable - shared by all accounts
        public static string bankName = "ABC Bank";
        public static int totalAccounts = 0;

        // readonly - cant change after assignment
        public readonly string AccountNumber;
        
        // regular variables
        public string AccountHolderName;
        public double balance;

        // constructor using this keyword
        public BankAccount(string AccountHolderName, string AccountNumber, double balance)
        {
            this.AccountHolderName = AccountHolderName;  // this resolves ambiguity
            this.AccountNumber = AccountNumber;          // this resolves ambiguity
            this.balance = balance;
            totalAccounts++;  // increment count
        }

        // static method
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
            Console.WriteLine("Bank: " + bankName);
        }

        public void showAccount()
        {
            Console.WriteLine("Account: " + AccountNumber);
            Console.WriteLine("Holder: " + AccountHolderName);
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create accounts
            BankAccount acc1 = new BankAccount("John", "12345", 1000);
            BankAccount acc2 = new BankAccount("Alice", "67890", 2000);

            // using is operator to check type
            object obj = acc1;
            if (obj is BankAccount)
            {
                Console.WriteLine("Object is BankAccount - showing details:");
                acc1.showAccount();
            }

            acc2.showAccount();

            // call static method
            BankAccount.GetTotalAccounts();

            Console.ReadLine();
        }
    }
}