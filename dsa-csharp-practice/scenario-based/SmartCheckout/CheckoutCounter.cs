using System;

public class CheckoutCounter
    {
        private Queue<Customer> _queue = new Queue<Customer>();
        private Inventory _inventory;

        public CheckoutCounter(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void AddCustomer(Customer customer)
        {
            _queue.Enqueue(customer);
        }

        public void ProcessAll()
        {
            while (_queue.Count > 0)
            {
                Customer current = _queue.Dequeue();
                double totalBill = 0;
                Console.WriteLine($"Processing bill for: {current.Name}");

                foreach (var itemName in current.Cart)
                {
                    if (_inventory.TryGetProduct(itemName, out Product item))
                    {
                        if (item.Stock > 0)
                        {
                            totalBill += item.Price;
                            _inventory.ReduceStock(itemName);
                            Console.WriteLine($"  - {itemName}: ${item.Price}");
                        }
                        else
                        {
                            Console.WriteLine($"  - {itemName}: OUT OF STOCK");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"  - {itemName}: Item not found");
                    }
                }
                Console.WriteLine($"  Total: ${totalBill}\n");
            }
        }
    }