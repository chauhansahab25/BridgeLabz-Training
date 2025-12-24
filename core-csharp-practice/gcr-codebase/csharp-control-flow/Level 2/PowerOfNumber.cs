using System;

   public class PowerOfNumber{
 
   
         public static void Main(string[] args){
		 
            Console.Write("Enter a number");
            int n = 5;    //Enter a number

         Console.Write("Enter a power");
            int p = 3;   // Enter a power
			
			
            int res = 1;
			
			// loop from 1 to power
			
		
            for (int i =1;i<=p;i++){

             // calculating result
   
   
             res = res*n;
  }
  
  
           Console.WriteLine("Result: " + res);
  
     }
}