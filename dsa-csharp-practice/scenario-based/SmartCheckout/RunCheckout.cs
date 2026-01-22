using System;

public class RunCheckout
{
    public static void Main(string[] args)
    {
        Inventory storeInventory = new Inventory();
        storeInventory.AddProduct("Milk", 2.50, 10);
        storeInventory.AddProduct("Bread", 1.20, 5);
        storeInventory.AddProduct("Eggs", 3.00, 2);
        storeInventory.AddProduct("Chocolate", 5.00, 20);

        CheckoutCounter counter = new CheckoutCounter(storeInventory);

        counter.AddCustomer(new Customer("Dev", "Milk", "Bread"));
        counter.AddCustomer(new Customer("Risita", "Eggs", "Milk", "Chocolate"));
        counter.AddCustomer(new Customer("Ramaa", "Eggs", "Bread")); 
        counter.AddCustomer(new Customer("Priyansuuuuuu", "Chocolate", "Milk"));
        counter.AddCustomer(new Customer("Lovish", "Bread", "UnknownItem"));
        counter.AddCustomer(new Customer("Gavindar", "Eggs")); 

        counter.ProcessAll();
    }
}