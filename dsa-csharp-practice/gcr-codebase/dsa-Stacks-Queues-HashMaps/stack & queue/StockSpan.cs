using System;
using System.Collections.Generic;

namespace CG_Practice.dsacsharp
{
    public class StockSpan
    {
        public int[] CalculateSpan(int[] prices)
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