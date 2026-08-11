using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool[] visited = new bool[n];
        int swaps = 0;
        for (int i = 0; i < n; i++)
        {
            if (visited[i] || arr[i] == i + 1)
                continue;

            int current = i;
            int cycleSize = 0;

            while (!visited[current])
            {
                visited[current] = true;

                current = arr[current] - 1;

                cycleSize++;
            }

            swaps += cycleSize - 1;
        }
        Console.WriteLine(swaps);
    }
}