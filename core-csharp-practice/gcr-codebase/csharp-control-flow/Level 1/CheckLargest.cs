using System;

class CheckLargest
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int n3 = int.Parse(Console.ReadLine());

        bool firstLargest = (n1 > n2 && n1 > n3);
        bool secondLargest = (n2 > n1 && n2 > n3);
        bool thirdLargest = (n3 > n1 && n3 > n2);

        Console.WriteLine("Is the first number the largest? " + firstLargest);
        Console.WriteLine("Is the second number the largest? " + secondLargest);
        Console.WriteLine("Is the third number the largest? " + thirdLargest);
    }
}