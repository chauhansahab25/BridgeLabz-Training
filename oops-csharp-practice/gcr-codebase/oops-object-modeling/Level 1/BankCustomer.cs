using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // customer class
    class Customer
    {
        public string Name;
        public string AccountNumber;
        public double Balance;
        public Bank bank;  // associated with a bank

        public Customer(string name)
        {
            Name = name;
            Balance = 0;
        }

        // view account balance
        public void ViewBalance()
        {
            Console.WriteLine(Name + "'s balance: $" + Balance);
        }

        public void showCustomer()
        {
            Console.WriteLine("Customer: " + Name + ", Account: " + AccountNumber);
        }
    }

    // bank class
    class Bank
    {
        public string BankName;
        public List<Customer> customers;  // list of customers

        public Bank(string name)
        {
            BankName = name;
            customers = new List<Customer>();
        }

        // open account for customer (association)
        public void OpenAccount(Customer customer, double initialDeposit)
        {
            customer.AccountNumber = "ACC" + (customers.Count + 1);  // simple account number
            customer.Balance = initialDeposit;
            customer.bank = this;  // associate customer with bank
            
            customers.Add(customer);
            Console.WriteLine("Account opened for " + customer.Name + " at " + BankName);
        }

        // show all customers
        public void showAllCustomers()
        {
            Console.WriteLine("Customers at " + BankName + ":");
            foreach (Customer customer in customers)
            {
                customer.showCustomer();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create bank
            Bank bank1 = new Bank("ABC Bank");

            // create customers
            Customer c1 = new Customer("john");
            Customer c2 = new Customer("alice");

            // open accounts (association)
            bank1.OpenAccount(c1, 1000);
            bank1.OpenAccount(c2, 2000);

            // show bank customers
            bank1.showAllCustomers();

            // customers can view their balance
            c1.ViewBalance();
            c2.ViewBalance();

            Console.ReadLine();
        }
    }
}