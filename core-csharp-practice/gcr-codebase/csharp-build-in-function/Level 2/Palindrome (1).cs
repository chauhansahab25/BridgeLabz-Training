using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class Palindrome
    {
        static bool IsPalindrome(string text)
        {
            int start = 0, end = text.Length - 1;

            while (start < end)
            {
                if (text[start] != text[end]) return false;
                start++;
                end--;
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            Console.WriteLine(IsPalindrome(text) ? "Palindrome" : "Not a Palindrome");
        }
    }
}
