using System;

class Ticket
{
    public int id;
    public string customerName;
    public string movieName;
    public string seatNumber;
    public string bookingTime;
    public Ticket next;
}

class TicketSystem
{
    Ticket head;
    Ticket tail;
    
    public void AddTicket(int i, string cn, string mn, string sn, string bt)
    {
        Ticket t = new Ticket();
        t.id = i; t.customerName = cn; t.movieName = mn; t.seatNumber = sn; t.bookingTime = bt;
        
        if (head == null)
        {
            head = tail = t;
            t.next = t;
        }
        else
        {
            tail.next = t;
            t.next = head;
            tail = t;
        }
    }
    
    public void RemoveTicket(int i)
    {
        if (head == null) return;
        
        if (head.id == i && head.next == head)
        {
            head = tail = null;
            return;
        }
        
        if (head.id == i)
        {
            tail.next = head.next;
            head = head.next;
            return;
        }
        
        Ticket temp = head;
        while (temp.next != head && temp.next.id != i)
            temp = temp.next;
        
        if (temp.next.id == i)
        {
            if (temp.next == tail)
                tail = temp;
            temp.next = temp.next.next;
        }
    }
    
    public void Display()
    {
        if (head == null) return;
        Ticket temp = head;
        do
        {
            Console.WriteLine($"{temp.id} {temp.customerName} {temp.movieName} {temp.seatNumber} {temp.bookingTime}");
            temp = temp.next;
        } while (temp != head);
    }
    
    public Ticket SearchByCustomer(string cn)
    {
        if (head == null) return null;
        Ticket temp = head;
        do
        {
            if (temp.customerName == cn) return temp;
            temp = temp.next;
        } while (temp != head);
        return null;
    }
    
    public Ticket SearchByMovie(string mn)
    {
        if (head == null) return null;
        Ticket temp = head;
        do
        {
            if (temp.movieName == mn) return temp;
            temp = temp.next;
        } while (temp != head);
        return null;
    }
    
    public int CountTickets()
    {
        if (head == null) return 0;
        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.next;
        } while (temp != head);
        return count;
    }
}