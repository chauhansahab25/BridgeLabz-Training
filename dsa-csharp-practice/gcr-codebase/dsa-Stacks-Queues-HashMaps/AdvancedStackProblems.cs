using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class AdvancedStackProblems
    {
        // Queue using two stacks
        public class QueueUsingStacks
        {
            private Stack<int> s1, s2;

            public QueueUsingStacks()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();
            }

            public void Enqueue(int x) => s1.Push(x);

            public int Dequeue()
            {
                if (s2.Count == 0)
                    while (s1.Count > 0)
                        s2.Push(s1.Pop());
                return s2.Pop();
            }
        }

        // Sort stack using recursion
        public void SortStack(Stack<int> stk)
        {
            if (stk.Count > 0)
            {
                int temp = stk.Pop();
                SortStack(stk);
                InsertSorted(stk, temp);
            }
        }

        private void InsertSorted(Stack<int> stk, int val)
        {
            if (stk.Count == 0 || stk.Peek() <= val)
            {
                stk.Push(val);
                return;
            }
            int temp = stk.Pop();
            InsertSorted(stk, val);
            stk.Push(temp);
        }

        // Stock span problem
        public int[] StockSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            var stk = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stk.Count > 0 && prices[stk.Peek()] <= prices[i])
                    stk.Pop();
                
                span[i] = stk.Count == 0 ? i + 1 : i - stk.Peek();
                stk.Push(i);
            }
            return span;
        }
    }
}