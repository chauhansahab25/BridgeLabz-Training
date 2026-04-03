using System;

class Palindrome
{
    static void Main()
    {
        int n = 121, temp = n, rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine(temp == rev ? "Palindrome" : "Not Palindrome");
    }
}
