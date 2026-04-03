using System;

class Item
{
    public string name;
    public int id;
    public int qty;
    public double price;
    public Item next;
}

class InventoryList
{
    Item head;
    
    public void AddFirst(string n, int i, int q, double p)
    {
        Item item = new Item();
        item.name = n; item.id = i; item.qty = q; item.price = p;
        item.next = head; head = item;
    }
    
    public void AddLast(string n, int i, int q, double p)
    {
        Item item = new Item();
        item.name = n; item.id = i; item.qty = q; item.price = p;
        if (head == null) { head = item; return; }
        Item temp = head;
        while (temp.next != null) temp = temp.next;
        temp.next = item;
    }
    
    public void AddAt(int pos, string n, int i, int q, double p)
    {
        if (pos == 0) { AddFirst(n, i, q, p); return; }
        Item item = new Item();
        item.name = n; item.id = i; item.qty = q; item.price = p;
        Item temp = head;
        for (int j = 0; j < pos - 1 && temp != null; j++) temp = temp.next;
        if (temp != null) { item.next = temp.next; temp.next = item; }
    }
    
    public void Remove(int i)
    {
        if (head == null) return;
        if (head.id == i) { head = head.next; return; }
        Item temp = head;
        while (temp.next != null && temp.next.id != i) temp = temp.next;
        if (temp.next != null) temp.next = temp.next.next;
    }
    
    public void UpdateQty(int i, int q)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.id == i) { temp.qty = q; return; }
            temp = temp.next;
        }
    }
    
    public Item SearchById(int i)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.id == i) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public Item SearchByName(string n)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.name == n) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public double TotalValue()
    {
        double total = 0;
        Item temp = head;
        while (temp != null)
        {
            total += temp.qty * temp.price;
            temp = temp.next;
        }
        return total;
    }
    
    public void SortByName()
    {
        if (head == null) return;
        for (Item i = head; i != null; i = i.next)
        {
            for (Item j = i.next; j != null; j = j.next)
            {
                if (string.Compare(i.name, j.name) > 0)
                {
                    string tn = i.name; i.name = j.name; j.name = tn;
                    int ti = i.id; i.id = j.id; j.id = ti;
                    int tq = i.qty; i.qty = j.qty; j.qty = tq;
                    double tp = i.price; i.price = j.price; j.price = tp;
                }
            }
        }
    }
    
    public void SortByPrice()
    {
        if (head == null) return;
        for (Item i = head; i != null; i = i.next)
        {
            for (Item j = i.next; j != null; j = j.next)
            {
                if (i.price > j.price)
                {
                    string tn = i.name; i.name = j.name; j.name = tn;
                    int ti = i.id; i.id = j.id; j.id = ti;
                    int tq = i.qty; i.qty = j.qty; j.qty = tq;
                    double tp = i.price; i.price = j.price; j.price = tp;
                }
            }
        }
    }
    
    public void Display()
    {
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.name} {temp.id} {temp.qty} {temp.price}");
            temp = temp.next;
        }
    }
}