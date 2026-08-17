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
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        StringBuilder sb = new StringBuilder(w);
        int i = sb.Length -2;
        while(i>=0 && sb[i] >= sb[i+1])
        {
            i--;
        }
        if(i<0)
        {
            return "no answer";
        }
        int j = sb.Length -1;
        while(sb[j]<=sb[i])
        {
            j--;
        }
        char temp = sb[i];
        sb[i] =sb[j];
        sb[j] = temp;
        int left = i+1;
        int right = sb.Length -1;
        while(left<right)
        {
            temp = sb[left];
            sb[left]=sb[right];
            sb[right]=temp;
            left++;
            right--;
        }
        return sb.ToString();
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}