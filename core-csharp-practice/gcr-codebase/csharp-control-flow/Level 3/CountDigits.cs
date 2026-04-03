using System;

class CountDigits
{
    static void Main()
    {
       
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        
        int count = 0;
        
        while (num != 0)
        {
            
            num = num / 10;
            
            
            count++;
        }
        
        Console.WriteLine("Number of digits: " + count);
        
        Console.ReadLine();
    }
}
