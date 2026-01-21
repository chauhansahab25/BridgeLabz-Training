using System;
using System.Collections.Generic;

class RevQ
{
    static void ReverseQueue(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int front = queue.Dequeue();
        ReverseQueue(queue);
        queue.Enqueue(front);
    }

    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        ReverseQueue(q);

        foreach (int item in q)
            Console.Write(item + " ");
    }
}
