using System;
  
  public class Profit{
  public static void Main(string[] args){
  
  
  int CostPrice=129;
  int SellingPrice=191;
  
  int profit = SellingPrice-CostPrice;
  
  double profitPercentage = (double)profit / CostPrice * 100;
  
        Console.WriteLine(
             "The Cost Price is INR " + CostPrice + " and Selling Price is INR " + SellingPrice); 
        Console.WriteLine("The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage + "%");
  
  
  
}
  
  
}