using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class QueueProblems
    {
        // Custom Queue implementation
        public class MyQueue<T>
        {
            private T[] arr;
            private int front, rear, size, cap;

            public MyQueue(int capacity)
            {
                arr = new T[capacity];
                cap = capacity;
                front = size = 0;
                rear = cap - 1;
            }

            public void Enqueue(T item)
            {
                if (size == cap) throw new InvalidOperationException();
                rear = (rear + 1) % cap;
                arr[rear] = item;
                size++;
            }

            public T Dequeue()
            {
                if (size == 0) throw new InvalidOperationException();
                T item = arr[front];
                front = (front + 1) % cap;
                size--;
                return item;
            }

            public bool IsEmpty() => size == 0;
        }

        // Circular Queue
        public class CircularQueue
        {
            private int[] arr;
            private int front, rear, size, cap;

            public CircularQueue(int k)
            {
                arr = new int[k];
                cap = k;
                front = rear = size = 0;
            }

            public bool EnQueue(int val)
            {
                if (size == cap) return false;
                arr[rear] = val;
                rear = (rear + 1) % cap;
                size++;
                return true;
            }

            public bool DeQueue()
            {
                if (size == 0) return false;
                front = (front + 1) % cap;
                size--;
                return true;
            }

            public int Front() => size == 0 ? -1 : arr[front];
            public int Rear() => size == 0 ? -1 : arr[(rear - 1 + cap) % cap];
            public bool IsEmpty() => size == 0;
            public bool IsFull() => size == cap;
        }

        // First Non-Repeating Character in Stream
        public char FirstNonRepeating(string stream)
        {
            var freq = new int[26];
            var q = new Queue<char>();

            foreach (char c in stream)
            {
                freq[c - 'a']++;
                q.Enqueue(c);

                while (q.Count > 0 && freq[q.Peek() - 'a'] > 1)
                    q.Dequeue();
            }

            return q.Count == 0 ? '#' : q.Peek();
        }
    }
}