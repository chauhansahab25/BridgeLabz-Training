using System;

class Reverseno
{
    static void Main()
    {
        int n = 123, rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine("Reverse = " + rev);
    }
}
