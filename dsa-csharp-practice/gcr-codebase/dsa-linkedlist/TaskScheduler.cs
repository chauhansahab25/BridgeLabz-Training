using System;

class Task
{
    public int id;
    public string name;
    public int priority;
    public string dueDate;
    public Task next;
}

class TaskScheduler
{
    Task head;
    Task current;
    
    public void AddFirst(int i, string n, int p, string d)
    {
        Task t = new Task();
        t.id = i; t.name = n; t.priority = p; t.dueDate = d;
        if (head == null) { head = t; t.next = t; current = t; }
        else
        {
            Task temp = head;
            while (temp.next != head) temp = temp.next;
            t.next = head; temp.next = t; head = t;
        }
    }
    
    public void AddLast(int i, string n, int p, string d)
    {
        Task t = new Task();
        t.id = i; t.name = n; t.priority = p; t.dueDate = d;
        if (head == null) { head = t; t.next = t; current = t; }
        else
        {
            Task temp = head;
            while (temp.next != head) temp = temp.next;
            temp.next = t; t.next = head;
        }
    }
    
    public void AddAt(int pos, int i, string n, int p, string d)
    {
        if (pos == 0) { AddFirst(i, n, p, d); return; }
        Task t = new Task();
        t.id = i; t.name = n; t.priority = p; t.dueDate = d;
        Task temp = head;
        for (int j = 0; j < pos - 1; j++) temp = temp.next;
        t.next = temp.next; temp.next = t;
    }
    
    public void Remove(int i)
    {
        if (head == null) return;
        if (head.id == i && head.next == head) { head = null; current = null; return; }
        if (head.id == i)
        {
            Task temp = head;
            while (temp.next != head) temp = temp.next;
            temp.next = head.next; head = head.next;
            if (current.id == i) current = head;
            return;
        }
        Task prev = head;
        while (prev.next != head && prev.next.id != i) prev = prev.next;
        if (prev.next.id == i)
        {
            if (current == prev.next) current = prev.next.next;
            prev.next = prev.next.next;
        }
    }
    
    public Task ViewCurrent()
    {
        return current;
    }
    
    public void MoveNext()
    {
        if (current != null) current = current.next;
    }
    
    public void Display()
    {
        if (head == null) return;
        Task temp = head;
        do
        {
            Console.WriteLine($"{temp.id} {temp.name} {temp.priority} {temp.dueDate}");
            temp = temp.next;
        } while (temp != head);
    }
    
    public Task SearchByPriority(int p)
    {
        if (head == null) return null;
        Task temp = head;
        do
        {
            if (temp.priority == p) return temp;
            temp = temp.next;
        } while (temp != head);
        return null;
    }
}