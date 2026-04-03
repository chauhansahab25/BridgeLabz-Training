using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class PalindromeCheck
    {
        static bool IsPalindrome(string input)
        {

            int start = 0;
            int end = input.Length - 1;

            while (start < end)
            {
                if (input[start] != input[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool result = IsPalindrome(input);

            if (result)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is NOT a palindrome.");
            }
        }
    }
}
