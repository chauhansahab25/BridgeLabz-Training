using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.BankingSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== BANKING SYSTEM ===");
            Console.WriteLine();

            // create different account types
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingsAccount("SAV001", "John Doe", 50000, 4.5));
            accounts.Add(new CurrentAccount("CUR001", "ABC Company", 100000, 20000));

            Console.WriteLine("=== ACCOUNT OPERATIONS ===");
            foreach (BankAccount acc in accounts)
            {
                acc.ShowAccountInfo();
                double interest = acc.CalculateInterest();
                Console.WriteLine("Interest: $" + interest);

                if (acc is ILoanable)
                {
                    ILoanable loanAccount = (ILoanable)acc;
                    loanAccount.ApplyForLoan(75000);
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}