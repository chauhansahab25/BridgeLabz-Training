using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countSwaps' function below.
     *
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static void countSwaps(List<int> a)
    {
        int n=a.Count;
        int swapCount =0;
        for(int i=0; i<n; i++)
        {
            for(int j=0; j<n-1; j++)
            {
                if (a[j]>a[j+1])
                {
                    int temp =a[j];
                    a[j]=a[j+1];
                    a[j+1]=temp;
                    swapCount++;
                }
            }
        }
        Console.WriteLine("Array is sorted in "+ swapCount + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[n-1]);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        Result.countSwaps(a);
    }
}