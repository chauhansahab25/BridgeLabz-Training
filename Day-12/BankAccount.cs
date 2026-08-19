using System;
class BankAccount
{
    private string accountNumber;
    private double balance;
    public BankAccount(string accountNumber, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
        }
        else
        {
            Console.WriteLine("Invalid Deposit");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid Withdrawal");
        }
        else
        {
            balance = balance - amount;
        }
    }
    public double GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine();
        Console.Write("Enter Initial Balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, balance);
        Console.Write("Enter number of transactions: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter transaction (D/W Amount): ");
            string[] input = Console.ReadLine().Split();
            char type = Convert.ToChar(input[0]);
            double amount = Convert.ToDouble(input[1]);
            if (type == 'D')
            {
                account.Deposit(amount);
            }
            else if (type == 'W')
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Invalid Transaction");
            }
        }
        Console.WriteLine("Final Balance: " + account.GetBalance());
    }
}