// using System;
// using System.Collections.Generic;
// using System.IO;
// class Solution {
//     static void Main(String[] args) {
//        int q =Convert.ToInt32(Console.ReadLine());
//        Stack<int> stack1= new Stack<int>();
//        Stack<int> stack2= new Stack<int>();
       
//        for(int i=0; i<q; i++)
//        {
//         string[] input =Console.ReadLine().Split(' ');
//         if(input[0]=="1")
//         {
//             int value =Convert.ToInt32(input[1]);
//             stack1.Push(value);
//         }
//         else if(input[0]=="2")
//         {
//             if(stack2.Count ==0)
//             {
//                 while(stack1.Count>0)
//                 {
//                     stack2.Push(stack1.Pop());
//                 }
//             }
//             stack2.Pop();
//         }
//         else if(input[0] =="3")
//         {
//             if(stack2.Count ==0)
//             {
//                 while(stack1.Count>0)
//                 {
//                     stack2.Push(stack1.Pop());
//                 }
//             }
//             Console.WriteLine(stack2.Peek());
//         }
//        }
//     }
// }