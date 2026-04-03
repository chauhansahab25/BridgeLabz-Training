using System;
  
  public class FeeDiscount{
  public static void Main(string[] args){
  
  double fees=125000;
  double DisPer=10;
  
  double DisAmount= (fees*DisPer)/100;
  double DisPrice= fees-DisAmount;
  
  Console.WriteLine("The discount amount is INR " + DisAmount + 
  "and final discounted fees is INR " + DisPrice);
  
  
  }
  }