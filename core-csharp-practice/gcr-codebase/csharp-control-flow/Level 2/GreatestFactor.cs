using System;

 public class GreatestFactor{


   public static void Main(string[] args){
	
        
        Console.Write("Enter a number: ");// input user

        int num = Convert.ToInt32(Console.ReadLine());
		

        int greatestFactor = 1;  // initialize with 1

       
	   
        for (int i = num - 1; i >= 1; i--)// for loop
        {
            
			
			
            if (num % i == 0)
            {
			
			
			
                greatestFactor = i;
                break;   // break the loop
            }
        }

        Console.WriteLine("The greatest factor is: " + greatestFactor);
    }
}