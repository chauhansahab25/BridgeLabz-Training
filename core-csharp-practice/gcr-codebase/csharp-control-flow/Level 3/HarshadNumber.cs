using System;

class HarshadNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
 
        int orgnum = num;
        
     
        while (num != 0)
        {           
            sum = sum + (num % 10);
            num = num / 10;
        }
        
        if (orgnum % sum == 0)
        {          
            Console.WriteLine(orgnum + " is a Harshad Number");
        }
        else
        {
            Console.WriteLine(orgnum + " is not a Harshad Number");
        }
        
        Console.ReadLine();
    }
}
