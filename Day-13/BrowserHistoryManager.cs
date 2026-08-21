using System;
public class PageNode
{
    public string Url;
    public PageNode Prev;
    public PageNode Next;
    public PageNode(string url)
    {
        Url = url;
        Prev = null;
        Next = null;
    }
}

public class BrowserHistory
{
    private PageNode current;

    public BrowserHistory(string homepage)
    {
        current = new PageNode(homepage);
    }

    public void Visit(string url)
    {
        current.Next = null;
        PageNode newPage = new PageNode(url);
        newPage.Prev = current;
        current.Next = newPage;
        current = newPage;
    }

    public string Back(int steps)
    {
        while (steps > 0 && current.Prev != null)
        {
            current = current.Prev;
            steps--;
        }
        return current.Url;
    }

    public string Forward(int steps)
    {
        while (steps > 0 && current.Next != null)
        {
            current = current.Next;
            steps--;
        }
        return current.Url;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter homepage: ");
        string homepage = Console.ReadLine();
        BrowserHistory b = new BrowserHistory(homepage);
        int choice;
        do
        {
            Console.WriteLine("\n1. Visit Page");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. Go Forward");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter URL: ");
                    string url = Console.ReadLine();
                    b.Visit(url);
                    Console.WriteLine("Page visited.");
                    break;
                case 2:
                    Console.Write("Enter number of steps: ");
                    int backSteps = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Current Page: " + b.Back(backSteps));
                    break;
                case 3:
                    Console.Write("Enter number of steps: ");
                    int forwardSteps = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Current Page: " + b.Forward(forwardSteps));
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