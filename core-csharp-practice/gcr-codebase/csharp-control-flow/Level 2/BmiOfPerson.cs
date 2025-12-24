  
  using System;
   public class BmiOfPerson {
   
    public static void Main(string[] args) {
	
	    Console.Write("Enter your weight:");
		
        int weight = Convert.ToInt32(Console.ReadLine());

		
		Console.Write("Enter your height");
        float height = Convert.ToSingle(Console.ReadLine());

		
        height = height / 100;
		
		

        float bmi = weight/(height*height);//Use the formula BMI = weight / (height * height).

        if (bmi<=18.4){
		
            Console.WriteLine("UnderWieght");
        }
		
		else if(bmi>=18.5 && bmi<=24.9){
		
            Console.WriteLine("Normal");
        }
		
		else if(bmi>=25.0 && bmi<=39.9){
		
            Console.WriteLine("OverWeight");
        }
		
		else{
		
            Console.WriteLine("Obese");
        }
    }
}
