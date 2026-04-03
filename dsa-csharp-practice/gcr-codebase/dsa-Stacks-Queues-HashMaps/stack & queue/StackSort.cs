using System;
using System.Collections.Generic;

namespace CG_Practice.dsacsharp
{
    public class StackSort
    {
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
    }
}