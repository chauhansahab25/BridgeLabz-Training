using System;

namespace CG_Practice.oopsscenario.MetalFactoryPipeCutting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Metal Factory Pipe Cutting ===");
            Console.WriteLine();

            // price chart for different lengths
            int[] prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
            int rodLength = 8;

            PipeCutter cutter = new PipeCutter(prices, rodLength);

            // Scenario A: Find best cuts for rod length 8
            Console.WriteLine("=== Scenario A: Optimal Cutting ===");
            cutter.DisplayPriceChart();
            Console.WriteLine("Rod length: " + rodLength);
            Console.WriteLine();

            int maxRevenue = cutter.FindMaxRevenue();
            Console.WriteLine("Maximum revenue: $" + maxRevenue);
            cutter.ShowCuttingStrategy();
            Console.WriteLine();

            // Scenario B: Add custom order and check impact
            Console.WriteLine("=== Scenario B: Custom Order Impact ===");
            Console.WriteLine("Customer wants length 6 pieces at higher price");
            cutter.UpdatePrice(6, 22); // increase price for length 6
            
            int newRevenue = cutter.FindMaxRevenue();
            Console.WriteLine("New maximum revenue: $" + newRevenue);
            Console.WriteLine("Revenue increase: $" + (newRevenue - maxRevenue));
            cutter.ShowCuttingStrategy();
            Console.WriteLine();

            // Scenario C: Show unoptimized revenue
            Console.WriteLine("=== Scenario C: Unoptimized vs Optimized ===");
            int unoptimizedRevenue = cutter.GetUnoptimizedRevenue();
            Console.WriteLine("Unoptimized revenue (all 1-length cuts): $" + unoptimizedRevenue);
            Console.WriteLine("Optimized revenue: $" + newRevenue);
            Console.WriteLine("Lost revenue without optimization: $" + (newRevenue - unoptimizedRevenue));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}