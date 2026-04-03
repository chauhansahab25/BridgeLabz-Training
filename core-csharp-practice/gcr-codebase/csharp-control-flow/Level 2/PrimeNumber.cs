 using System;

  public class PrimeNumber {
  
    public static void Main(string[] args) {
     
	 Console.Write("Enter a number:");

        int number = Convert.ToInt32(Console.ReadLine());
		
        bool isPrime = true;

        for(int i=2;i<number;i++){
		

            if(number%i==0){  //A number that can be divided exactly only by itself and 1 are Prime Numbers,
			
                isPrime = false;
            }
        }
		
        Console.WriteLine(isPrime);
    }
}
