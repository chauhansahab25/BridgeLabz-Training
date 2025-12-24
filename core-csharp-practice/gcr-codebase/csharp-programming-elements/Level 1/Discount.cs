using System;
  
  public class Discount{
  public static void Main(string[] args){
  
  Console.Write("Enter fees: ");
  double fees=Convert.ToDouble(Console.ReadLine());
  
  Console.Write("Enter DiscountPercent: ");
  double DiscountPercent=Convert.ToDouble(Console.ReadLine());;
  
  double DiscountAmount= (fees*DiscountPercent)/100;
  double DiscountPrice= fees-DiscountAmount;
  
  Console.WriteLine("The discount amount is INR " + DiscountAmount + 
  "and final discounted fee is INR " + DiscountPrice);
  
  
  
  
  }
  

  }