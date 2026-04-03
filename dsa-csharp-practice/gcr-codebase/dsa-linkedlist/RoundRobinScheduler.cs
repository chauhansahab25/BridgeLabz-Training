using System;

class Process
{
    public int id;
    public int burstTime;
    public int priority;
    public int remainingTime;
    public int waitTime;
    public int turnTime;
    public Process next;
}

class RoundRobin
{
    Process head;
    Process tail;
    int quantum;
    
    public RoundRobin(int q) { quantum = q; }
    
    public void AddProcess(int i, int bt, int p)
    {
        Process pr = new Process();
        pr.id = i; pr.burstTime = bt; pr.priority = p; pr.remainingTime = bt;
        if (head == null) { head = tail = pr; pr.next = pr; }
        else { tail.next = pr; pr.next = head; tail = pr; }
    }
    
    public void RemoveProcess(int i)
    {
        if (head == null) return;
        if (head.id == i && head.next == head) { head = tail = null; return; }
        if (head.id == i)
        {
            tail.next = head.next; head = head.next; return;
        }
        Process temp = head;
        while (temp.next != head && temp.next.id != i) temp = temp.next;
        if (temp.next.id == i)
        {
            if (temp.next == tail) tail = temp;
            temp.next = temp.next.next;
        }
    }
    
    public void Schedule()
    {
        if (head == null) return;
        Process current = head;
        int time = 0;
        
        while (head != null)
        {
            if (current.remainingTime > quantum)
            {
                current.remainingTime -= quantum;
                time += quantum;
                current = current.next;
            }
            else
            {
                time += current.remainingTime;
                current.turnTime = time;
                current.waitTime = current.turnTime - current.burstTime;
                Console.WriteLine($"Process {current.id} completed at time {time}");
                
                Process next = current.next;
                RemoveProcess(current.id);
                current = next;
                if (head != null && current == null) current = head;
            }
        }
    }
    
    public void Display()
    {
        if (head == null) return;
        Process temp = head;
        do
        {
            Console.WriteLine($"{temp.id} {temp.burstTime} {temp.priority} {temp.remainingTime}");
            temp = temp.next;
        } while (temp != head);
    }
    
    public void CalculateAverage()
    {
        if (head == null) return;
        double totalWait = 0, totalTurn = 0;
        int count = 0;
        Process temp = head;
        do
        {
            totalWait += temp.waitTime;
            totalTurn += temp.turnTime;
            count++;
            temp = temp.next;
        } while (temp != head);
        
        Console.WriteLine($"Avg Wait Time: {totalWait / count}");
        Console.WriteLine($"Avg Turn Time: {totalTurn / count}");
    }
}