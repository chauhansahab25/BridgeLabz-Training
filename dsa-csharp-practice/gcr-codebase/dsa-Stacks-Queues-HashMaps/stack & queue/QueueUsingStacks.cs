using System;
using System.Collections.Generic;

namespace CG_Practice.dsacsharp
{
    public class QueueUsingStacks
    {
        private Stack<int> s1, s2;

        public QueueUsingStacks()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }
        public void Enqueue(int x)
        {
            s1.Push(x);
        }

        public int Dequeue()
        {
            if (s2.Count == 0)
            {
                while (s1.Count > 0)
                    s2.Push(s1.Pop());
            }
            return s2.Pop();
        }

        public bool IsEmpty() => s1.Count == 0 && s2.Count == 0;
    }
}