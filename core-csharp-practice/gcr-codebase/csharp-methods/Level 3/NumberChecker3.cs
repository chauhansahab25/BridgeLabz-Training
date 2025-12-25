using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class NumberChecker3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = CountDigits(number);
            int[] digits = GetDigits(number, count);
            int[] reversedArr = ReverseArray(digits);

            Console.Write("Reversed Digits: ");
            for (int i = 0; i < reversedArr.Length; i++) Console.Write(reversedArr[i]);
            Console.WriteLine();

            if (IsPalindrome(digits, reversedArr))
                Console.WriteLine("The number is a Palindrome.");
            else
                Console.WriteLine("The number is NOT a Palindrome.");

            if (IsDuck(digits))
                Console.WriteLine("It is a Duck Number.");
            else
                Console.WriteLine("It is NOT a Duck Number.");
        }

        static int CountDigits(int n)
        {
            int c = 0;
            int temp = n;
            while (temp > 0)
            {
                temp /= 10;
                c++;
            }
            return c;
        }

        static int[] GetDigits(int n, int count)
        {
            int[] arr = new int[count];
            int temp = n;
            for (int i = count - 1; i >= 0; i--)
            {
                arr[i] = temp % 10;
                temp /= 10;
            }
            return arr;
        }

        static int[] ReverseArray(int[] arr)
        {
            int[] rev = new int[arr.Length];
            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rev[index] = arr[i];
                index++;
            }
            return rev;
        }

        static bool CheckArraysEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        static bool IsPalindrome(int[] original, int[] reversed)
        {
            return CheckArraysEqual(original, reversed);
        }

        static bool IsDuck(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == 0) return true;
            }
            return false;
        }
    }
}
