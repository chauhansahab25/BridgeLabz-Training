using System;
using System.Collections.Generic;

public class Ticket
{
    public int Id;
    public string CustomerName;
    public int Priority;

    public Ticket(int id, string customerName, int priority)
    {
        Id = id;
        CustomerName = customerName;
        Priority = priority;
    }
}

public class SupportDesk
{
    private Dictionary<int, Queue<Ticket>> tickets;

    public SupportDesk()
    {
        tickets = new Dictionary<int, Queue<Ticket>>();
    }

    public void AddTicket(Ticket t)
    {
        if (!tickets.ContainsKey(t.Priority))
        {
            tickets[t.Priority] = new Queue<Ticket>();
        }

        tickets[t.Priority].Enqueue(t);
    }

    public Ticket ServeNext()
    {
        int selectedPriority = -1;

        foreach (int priority in tickets.Keys)
        {
            if (tickets[priority].Count > 0)
            {
                if (selectedPriority == -1 ||
                    priority < selectedPriority)
                {
                    selectedPriority = priority;
                }
            }
        }

        if (selectedPriority == -1)
        {
            return null;
        }

        return tickets[selectedPriority].Dequeue();
    }
    public List<Ticket> GetPendingSortedByPriority()
    {
        List<Ticket> result = new List<Ticket>();

        foreach (Queue<Ticket> queue in tickets.Values)
        {
            foreach (Ticket ticket in queue)
            {
                result.Add(ticket);
            }
        }

        result.Sort((a, b) =>
        {
            return a.Priority.CompareTo(b.Priority);
        });

        return result;
    }
}

class Program
{
    static void Main()
    {
        SupportDesk desk = new SupportDesk();
        int choice;
        do
        {
            Console.WriteLine("\n1. Add Ticket");
            Console.WriteLine("2. Serve Next Ticket");
            Console.WriteLine("3. Show Pending Tickets");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Priority (1-5): ");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    Ticket ticket = new Ticket(id, name, priority);
                    desk.AddTicket(ticket);
                    Console.WriteLine("Ticket added.");
                    break;
                case 2:
                    Ticket served = desk.ServeNext();
                    if (served == null)
                    {
                        Console.WriteLine("No tickets available.");
                    }
                    else
                    {
                        Console.WriteLine("Serving:");
                        Console.WriteLine("ID: " + served.Id);
                        Console.WriteLine("Name: " + served.CustomerName);
                        Console.WriteLine("Priority: " + served.Priority);
                    }
                    break;
                case 3:
                    List<Ticket> pending =
                        desk.GetPendingSortedByPriority();

                    if (pending.Count == 0)
                    {
                        Console.WriteLine("No pending tickets.");
                    }
                    else
                    {
                        Console.WriteLine("\nPending Tickets:");

                        foreach (Ticket t in pending)
                        {
                            Console.WriteLine(
                                "ID: " + t.Id +
                                ", Name: " + t.CustomerName +
                                ", Priority: " + t.Priority
                            );
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 4);
    }
}