using System;

 public class MultipleOfNumber{
   public static void Main(string[] args) {
	
	
	
        Console.Write("Enter a number: ");// taking input from user

        int n = Convert.ToInt32(Console.ReadLine());// loop start from 100 to 1



        for (int i = 100; i >= 1; i--)// multiple of a number below 100
        {
           
			
			
			if (i % n  == 0)//if remainder is zero then it is the factor of number
            {
			
                Console.WriteLine(i);
            }
        }
    }
}