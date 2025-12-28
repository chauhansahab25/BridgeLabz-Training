using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class CompareTwoString
    {
        static bool CompareUsingCharAt(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            }
            return true;
        }
        static void Main()
        {
            Console.WriteLine("Enter first String:");
            string inp1 = Console.ReadLine();

            Console.WriteLine("Enter second String:");
            string inp2 = Console.ReadLine();

            bool cstmrslt = CompareUsingCharAt(inp1,inp2);
            Console.WriteLine($" Custom CharAt comparison: {cstmrslt}");

            bool builtinrslt = inp1.Equals(inp2);
            Console.WriteLine($"Built-in Equals comparison: {builtinrslt}");


            Console.WriteLine($"Result match: {cstmrslt == builtinrslt}");
        }

    }
}
