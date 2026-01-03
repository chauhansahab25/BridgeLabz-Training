using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class BankAccount
    {
        static string bankName = "ABC Bank";  // same for all
        static int totalAccounts = 0;

        readonly string AccountNumber;  // cant change this
        
        string AccountHolderName;
        double balance;

        public BankAccount(string AccountHolderName, string AccountNumber, double balance)
        {
            this.AccountHolderName = AccountHolderName;  // using this cuz same name
            this.AccountNumber = AccountNumber;
            this.balance = balance;
            totalAccounts++;
        }

        static void GetTotalAccounts()
        {
            Console.WriteLine("Total accounts: " + totalAccounts);
            Console.WriteLine("Bank name: " + bankName);
        }

        void showAccount()
        {
            Console.WriteLine("Acc no: " + AccountNumber);
            Console.WriteLine("Name: " + AccountHolderName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount acc1 = new BankAccount("john", "12345", 1000);
            BankAccount acc2 = new BankAccount("alice", "67890", 2000);

            object obj = acc1;
            if (obj is BankAccount)  // check if its bankaccount type
            {
                Console.WriteLine("yes its bankaccount:");
                acc1.showAccount();
            }

            acc2.showAccount();
            BankAccount.GetTotalAccounts();

            Console.ReadLine();
        }
    }
}