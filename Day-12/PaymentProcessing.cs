using System;
using System.Collections.Generic;
interface IPayment
{
    void Pay(double amount);
}
class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}
class UpiPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using UPI");
    }
}
class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Cash");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of payments: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<IPayment> payments = new List<IPayment>();
        List<double> amounts = new List<double>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter payment type (UPI/CARD/CASH): ");
            string type = Console.ReadLine();

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (type.ToLower() == "upi")
            {
                payments.Add(new UpiPayment());
            }
            else if (type.ToLower() == "card")
            {
                payments.Add(new CreditCardPayment());
            }
            else if (type.ToLower() == "cash")
            {
                payments.Add(new CashPayment());
            }
            else
            {
                Console.WriteLine("Invalid payment type");
                continue;
            }
            amounts.Add(amount);
        }
        Console.WriteLine("\nPayment Details:");
        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].Pay(amounts[i]);
        }
    }
}