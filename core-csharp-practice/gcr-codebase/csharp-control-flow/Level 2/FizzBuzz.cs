
 using System;
 
 public class FizzBuzz 
{
    public static void Main(string[] args) 
    {
        
        Console.Write("Enter the number");
        int number=Convert.ToInt32(Console.ReadLine());

        
        if (number <= 0) {
            Console.WriteLine("The number must be a positive integer.");// Check if the number is positive
        }

        
		
        for (int i = 1; i <= number; i++) {      // FizzBuzz logic
		
            if (i % 3 == 0 && i % 5 == 0) {
			
                Console.WriteLine("FizzBuzz");
            }
			
			else if (i % 3 == 0) {
			
                Console.WriteLine("Fizz");
            }
			
			else if (i % 5 == 0) {
			
              Console.WriteLine("Buzz");
            }
        }


    }
}