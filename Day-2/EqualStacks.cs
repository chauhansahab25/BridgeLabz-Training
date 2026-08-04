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
//      * Complete the 'equalStacks' function below.
//      *
//      * The function is expected to return an INTEGER.
//      * The function accepts following parameters:
//      *  1. INTEGER_ARRAY h1
//      *  2. INTEGER_ARRAY h2
//      *  3. INTEGER_ARRAY h3
//      */

//     public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
//     {
//         Stack<int> s1 =new Stack<int>();
//         Stack<int> s2 =new Stack<int>();
//         Stack<int> s3 =new Stack<int>();
        
//         int sum1=0;
//         int sum2=0;
//         int sum3=0;
//         for(int i=h1.Count-1; i>=0;i--)
//         {
//             s1.Push(h1[i]);
//         }
//         foreach(int x in h1)
//         {
//             sum1+=x;
//         }
//         for(int i=h2.Count-1; i>=0; i--)
//         {
//             s2.Push(h2[i]);
//         }
//         foreach(int x in h2)
//         {
//             sum2+=x;
//         }
//         for(int i=h3.Count-1; i>=0; i--)
//         {
//             s3.Push(h3[i]);
//         }
//         foreach(int x in h3)
//         {
//             sum3+=x;
//         }
        
//         while(true)
//         {
//             if(sum1==sum2 && sum2==sum3)
//             {
//                 return sum1;
//             }
//             if(sum1>=sum2 && sum1>=sum3)
//             {
//                 if(s1.Count==0)
//                 {
//                     return 0;
//                 }
//                 sum1-=s1.Pop();
                
//             }
//             else if(sum2>=sum1 && sum2>=sum3)
//             {
//                 if(s2.Count==0)
//                 {
//                     return 0;
//                 }
//                 sum2-=s2.Pop();
//             }
//             else
//             {
//                 if(s3.Count==0)
//                 {
//                     return 0;
//                 }
//                 sum3-=s3.Pop();
//             }
//         }


//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//         int n1 = Convert.ToInt32(firstMultipleInput[0]);

//         int n2 = Convert.ToInt32(firstMultipleInput[1]);

//         int n3 = Convert.ToInt32(firstMultipleInput[2]);

//         List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

//         List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

//         List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

//         int result = Result.equalStacks(h1, h2, h3);

//         textWriter.WriteLine(result);

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }