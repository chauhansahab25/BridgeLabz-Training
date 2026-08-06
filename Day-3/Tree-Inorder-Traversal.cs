using System;
using System.Collections.Generic;
using System.IO;
class Node
{
    public int data;
    public Node left,right;
    public Node(int value)
    {
        data=value;
    }
}
class Solution {
    static Node insert(Node root , int data) 
    {
        if(root == null)
        {
            return new Node(data);
        }
        if(data<=root.data)
        {
            root.left=insert(root.left,data);
        }
        else
        {
            root.right = insert(root.right,data);
        }
        return root;

        
    }
    static void inOrder(Node root)
    {
        if(root ==null)
        {
            return;
        }
        inOrder(root.left);
        Console.Write(root.data + " ");
        inOrder(root.right);
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');
        Node root =null;
        for(int i =0; i<n; i++)
        {
            root = insert(root,int.Parse(arr[i]));
        }
        inOrder(root);
    }
}