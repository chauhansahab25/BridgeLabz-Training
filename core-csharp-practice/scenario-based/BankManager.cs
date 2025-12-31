using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.scenariobased
{
    public class BankManager
    {
        static void Main(string[] args)
        {
            string accountnumber = "";
            while (accountnumber.Length != 10)
            {
                Console.WriteLine("Enter 10 digit Account Number");//Account number
                accountnumber = Console.ReadLine();
                if (accountnumber.Length != 10)
                {
                    Console.WriteLine("Invalid Account number!. Enter a valid account number");
                }

            }
            Random rand = new Random();
            double balance = rand.Next(0, 10000000);
            bool resumeBanking = true;

            while (resumeBanking)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Deposit amount: ");
                Console.WriteLine("2. Withdrawal amount: ");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose a option (1-4): ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the amount to deposit");//Deposit
                        double depoamt = Convert.ToDouble(Console.ReadLine());
                        balance = Deposit(balance, depoamt);
                        Console.WriteLine("Balance after deposit: " + balance);
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount to withdrawal");//Withdrawal
                        double withamt = Convert.ToDouble(Console.ReadLine());
                        balance = Withdrawal(balance, withamt);
                        Console.WriteLine("Balance after Withdrawal: " + balance);
                        break;
                    case "3":
                        CheckBalance(balance);//Checkbalance
                        break;
                    case "4":
                        Console.WriteLine("THankyou for banking with us");
                        resumeBanking = false;
                        break;
                    default:
                        Console.WriteLine("Please Choose a valid option");
                        break;

                }
            }

        }

        static double Deposit(double currentbalance ,double amount)
        {
            if(amount > 0)
            {
                currentbalance += amount;
                Console.WriteLine("Deposited money: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }

            return currentbalance;
        }

        static double Withdrawal(double currentbalance , double amount)
        {
            if (amount >0 &&  amount <= currentbalance)
            {
                currentbalance -= amount;
                Console.WriteLine("Withdrawal money: " + amount);
            }
            else
            {
                Console.WriteLine("You have insufficient variable");
            }
            return currentbalance;
        }

        static void CheckBalance(double currentbalance)
        {
            Console.WriteLine("Total balance in your account: " + currentbalance);
        }

    }
}
