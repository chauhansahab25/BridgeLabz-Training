using System;

class Movie
{
    public string title;
    public string director;
    public int year;
    public double rating;
    public Movie next;
    public Movie prev;
}

class MovieList
{
    Movie head;
    Movie tail;
    
    public void AddFirst(string t, string d, int y, double r)
    {
        Movie m = new Movie();
        m.title = t; m.director = d; m.year = y; m.rating = r;
        if (head == null) { head = tail = m; }
        else { m.next = head; head.prev = m; head = m; }
    }
    
    public void AddLast(string t, string d, int y, double r)
    {
        Movie m = new Movie();
        m.title = t; m.director = d; m.year = y; m.rating = r;
        if (tail == null) { head = tail = m; }
        else { tail.next = m; m.prev = tail; tail = m; }
    }
    
    public void AddAt(int pos, string t, string d, int y, double r)
    {
        if (pos == 0) { AddFirst(t, d, y, r); return; }
        Movie m = new Movie();
        m.title = t; m.director = d; m.year = y; m.rating = r;
        Movie temp = head;
        for (int i = 0; i < pos && temp != null; i++) temp = temp.next;
        if (temp != null)
        {
            m.next = temp; m.prev = temp.prev;
            if (temp.prev != null) temp.prev.next = m;
            temp.prev = m;
        }
    }
    
    public void Remove(string t)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.title == t)
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
    
    public Movie SearchByDirector(string d)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.director == d) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public Movie SearchByRating(double r)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.rating == r) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public void DisplayForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.title} {temp.director} {temp.year} {temp.rating}");
            temp = temp.next;
        }
    }
    
    public void DisplayReverse()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.title} {temp.director} {temp.year} {temp.rating}");
            temp = temp.prev;
        }
    }
    
    public void UpdateRating(string t, double r)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.title == t) { temp.rating = r; return; }
            temp = temp.next;
        }
    }
}