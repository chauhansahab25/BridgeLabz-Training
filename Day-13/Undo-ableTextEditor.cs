using System;
using System.Collections.Generic;
using System.Text;

public class Operation
{
    public string Type;
    public string Text;
    public Operation(string type, string text)
    {
        Type = type;
        Text = text;
    }
}

public class TextEditor
{
    private StringBuilder content;
    private Stack<Operation> history;
    public TextEditor()
    {
        content = new StringBuilder();
        history = new Stack<Operation>();
    }

    public void Type(string text)
    {
        content.Append(text);
        history.Push(new Operation("type", text));
    }

    public void Delete(int n)
    {
        if (n > content.Length)
        {
            Console.WriteLine("Cannot delete more characters than available.");
            return;
        }

        int start = content.Length - n;
        string deletedText = content.ToString(start, n);
        content.Remove(start, n);
        history.Push(new Operation("delete", deletedText));
    }

    public void Undo()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }
        Operation lastOperation = history.Pop();
        if (lastOperation.Type == "type")
        {
            int length = lastOperation.Text.Length;
            content.Remove(content.Length - length, length);
        }
        else
        {
            content.Append(lastOperation.Text);
        }
    }
    public string GetText()
    {
        return content.ToString();
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        int choice;

        do
        {
            Console.WriteLine("\n1. Type Text");
            Console.WriteLine("2. Delete Characters");
            Console.WriteLine("3. Undo");
            Console.WriteLine("4. Show Text");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter text: ");
                    string text = Console.ReadLine();
                    editor.Type(text);
                    break;
                case 2:
                    Console.Write("Enter number of characters to delete: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    editor.Delete(n);
                    break;
                case 3:
                    editor.Undo();
                    Console.WriteLine("Undo completed.");
                    break;
                case 4:
                    Console.WriteLine("Current Text: " + editor.GetText());
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 5);
    }
}