using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class CustomHashMap<K, V>
    {
        private class Node
        {
            public K Key;
            public V Value;
            public Node Next;

            public Node(K key, V value)
            {
                Key = key;
                Value = value;
            }
        }

        private Node[] buckets;
        private int size;
        private int cap;

        public CustomHashMap(int capacity = 16)
        {
            cap = capacity;
            buckets = new Node[cap];
            size = 0;
        }

        private int Hash(K key) => Math.Abs(key.GetHashCode()) % cap;

        public void Put(K key, V value)
        {
            int idx = Hash(key);
            Node head = buckets[idx];

            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }

            Node newNode = new Node(key, value);
            newNode.Next = buckets[idx];
            buckets[idx] = newNode;
            size++;
        }

        public V Get(K key)
        {
            int idx = Hash(key);
            Node head = buckets[idx];

            while (head != null)
            {
                if (head.Key.Equals(key))
                    return head.Value;
                head = head.Next;
            }
            throw new KeyNotFoundException();
        }

        public bool Remove(K key)
        {
            int idx = Hash(key);
            Node head = buckets[idx];

            if (head == null) return false;

            if (head.Key.Equals(key))
            {
                buckets[idx] = head.Next;
                size--;
                return true;
            }

            while (head.Next != null)
            {
                if (head.Next.Key.Equals(key))
                {
                    head.Next = head.Next.Next;
                    size--;
                    return true;
                }
                head = head.Next;
            }
            return false;
        }

        public int Size() => size;
        public bool IsEmpty() => size == 0;
    }
}