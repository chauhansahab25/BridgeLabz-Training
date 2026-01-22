using System;

public class Inventory
    {
        private Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void AddProduct(string name, double price, int stock)
        {
            _products[name] = new Product { Price = price, Stock = stock };
        }

        public bool TryGetProduct(string name, out Product product)
        {
            return _products.TryGetValue(name, out product);
        }

        public void ReduceStock(string name)
        {
            if (_products.ContainsKey(name) && _products[name].Stock > 0)
            {
                _products[name].Stock--;
            }
        }
    }