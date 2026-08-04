// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

// class Result
// {

//     /*
//      * Complete the 'getMax' function below.
//      *
//      * The function is expected to return an INTEGER_ARRAY.
//      * The function accepts STRING_ARRAY operations as parameter.
//      */

//     public static List<int> getMax(List<string> operations)
//     {
//         Stack<int> stack= new Stack<int>();
//         Stack<int> maxstack = new Stack<int>();
//         List<int> result= new List<int>();
//         for(int i=0; i<operations.Count; i++)
//         {
//             string[] arr=operations[i].Split(' ');
//             if(arr[0] == "1")
//             {
//                 int value=Convert.ToInt32(arr[1]);
//                 stack.Push(value);
//                 if(maxstack.Count==0 || value>=maxstack.Peek())
//                 {
//                     maxstack.Push(value);
//                 }
//             }
//             else if(arr[0]=="2")
//             {
//                 int removed= stack.Pop();
//                 if(removed==maxstack.Peek())
//                 {
//                     maxstack.Pop();
//                 }
//             }
//             else if (arr[0]=="3")
//             {
//                 result.Add(maxstack.Peek());
//             }
//         }
//         return result;
//    }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<string> ops = new List<string>();

//         for (int i = 0; i < n; i++)
//         {
//             string opsItem = Console.ReadLine();
//             ops.Add(opsItem);
//         }

//         List<int> res = Result.getMax(ops);

//         textWriter.WriteLine(String.Join("\n", res));

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }