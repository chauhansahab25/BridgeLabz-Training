using System;

class Book
{
    public string title;
    public string author;
    public string genre;
    public int id;
    public bool available;
    public Book next;
    public Book prev;
}

class LibraryList
{
    Book head;
    Book tail;
    
    public void AddFirst(string t, string a, string g, int i, bool av)
    {
        Book b = new Book();
        b.title = t; b.author = a; b.genre = g; b.id = i; b.available = av;
        if (head == null) { head = tail = b; }
        else { b.next = head; head.prev = b; head = b; }
    }
    
    public void AddLast(string t, string a, string g, int i, bool av)
    {
        Book b = new Book();
        b.title = t; b.author = a; b.genre = g; b.id = i; b.available = av;
        if (tail == null) { head = tail = b; }
        else { tail.next = b; b.prev = tail; tail = b; }
    }
    
    public void AddAt(int pos, string t, string a, string g, int i, bool av)
    {
        if (pos == 0) { AddFirst(t, a, g, i, av); return; }
        Book b = new Book();
        b.title = t; b.author = a; b.genre = g; b.id = i; b.available = av;
        Book temp = head;
        for (int j = 0; j < pos && temp != null; j++) temp = temp.next;
        if (temp != null)
        {
            b.next = temp; b.prev = temp.prev;
            if (temp.prev != null) temp.prev.next = b;
            temp.prev = b;
        }
    }
    
    public void Remove(int i)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.id == i)
            {
                if (temp.prev != null) temp.prev.next = temp.next;
                else head = temp.next;
                if (temp.next != null) temp.next.prev = temp.prev;
                else tail = temp.prev;
                return;
            }
            temp = temp.next;
        }
    }
    
    public Book SearchByTitle(string t)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.title == t) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public Book SearchByAuthor(string a)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.author == a) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public void UpdateStatus(int i, bool av)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.id == i) { temp.available = av; return; }
            temp = temp.next;
        }
    }
    
    public void DisplayForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.title} {temp.author} {temp.genre} {temp.id} {temp.available}");
            temp = temp.next;
        }
    }
    
    public void DisplayReverse()
    {
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.title} {temp.author} {temp.genre} {temp.id} {temp.available}");
            temp = temp.prev;
        }
    }
    
    public int Count()
    {
        int c = 0;
        Book temp = head;
        while (temp != null) { c++; temp = temp.next; }
        return c;
    }
}