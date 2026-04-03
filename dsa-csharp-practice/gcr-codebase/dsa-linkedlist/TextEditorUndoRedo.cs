using System;

class TextState
{
    public string content;
    public TextState next;
    public TextState prev;
}

class TextEditor
{
    TextState head;
    TextState tail;
    TextState current;
    int maxSize;
    int size;
    
    public TextEditor(int max)
    {
        maxSize = max;
        size = 0;
    }
    
    public void AddState(string content)
    {
        TextState state = new TextState();
        state.content = content;
        
        if (current != null && current.next != null)
        {
            TextState temp = current.next;
            while (temp != null)
            {
                TextState toDelete = temp;
                temp = temp.next;
                size--;
            }
            current.next = null;
            tail = current;
        }
        
        if (head == null)
        {
            head = tail = current = state;
        }
        else
        {
            tail.next = state;
            state.prev = tail;
            tail = state;
            current = state;
        }
        
        size++;
        
        if (size > maxSize)
        {
            TextState toRemove = head;
            head = head.next;
            if (head != null) head.prev = null;
            size--;
        }
    }
    
    public string Undo()
    {
        if (current != null && current.prev != null)
        {
            current = current.prev;
            return current.content;
        }
        return current != null ? current.content : "";
    }
    
    public string Redo()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            return current.content;
        }
        return current != null ? current.content : "";
    }
    
    public string GetCurrentState()
    {
        return current != null ? current.content : "";
    }
    
    public void DisplayHistory()
    {
        TextState temp = head;
        int pos = 0;
        while (temp != null)
        {
            string marker = temp == current ? " <-- Current" : "";
            Console.WriteLine($"{pos}: {temp.content}{marker}");
            temp = temp.next;
            pos++;
        }
    }
}