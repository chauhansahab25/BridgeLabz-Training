using System;
using System.Collections.Generic;
using System.IO;

    class Node
    {
        public int data;
        public Node left,right;
        public Node(int data)
           {
               this.data=data;
               left=right=null;
           }
    }
       
    class Solution
    {
        static void preorder(Node root)
        {
            if(root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            preorder(root.left);
            preorder(root.right);
        }
    
        static void Main(string[] args)
         {
            int n =Convert.ToInt32(Console.ReadLine());
            Node root = null;
            string[] arr = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                root = Insert(root,int.Parse(arr[i]));
            }
            preorder(root);
         }
         static Node Insert(Node root,int data)
         {
            if(root==null)
            {
                return new Node(data);
                
            }
            if(data<=root.data)
            {
                root.left=Insert(root.left,data);
            }
            else
            {
                root.right =Insert(root.right,data);
            }
            return root;
         }  
            
         
      






        
          
    }


    



  
        
    