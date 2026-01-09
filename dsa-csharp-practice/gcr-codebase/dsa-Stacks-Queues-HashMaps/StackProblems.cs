using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class StackProblems
    {
        // Custom Stack implementation
        public class MyStack<T>
        {
            private T[] arr;
            private int top;
            private int cap;

            public MyStack(int size)
            {
                arr = new T[size];
                cap = size;
                top = -1;
            }

            public void Push(T item)
            {
                if (top == cap - 1) throw new StackOverflowException();
                arr[++top] = item;
            }

            public T Pop()
            {
                if (top == -1) throw new InvalidOperationException();
                return arr[top--];
            }

            public bool IsEmpty() => top == -1;
        }

        // Valid Parentheses Problem
        public bool IsValidParentheses(string s)
        {
            var stk = new Stack<char>();
            
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                    stk.Push(c);
                else
                {
                    if (stk.Count == 0) return false;
                    char top = stk.Pop();
                    if ((c == ')' && top != '(') || 
                        (c == ']' && top != '[') || 
                        (c == '}' && top != '{'))
                        return false;
                }
            }
            return stk.Count == 0;
        }

        // Next Greater Element
        public int[] NextGreaterElement(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            var stk = new Stack<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                while (stk.Count > 0 && stk.Peek() <= nums[i])
                    stk.Pop();
                
                res[i] = stk.Count == 0 ? -1 : stk.Peek();
                stk.Push(nums[i]);
            }
            return res;
        }
    }
}