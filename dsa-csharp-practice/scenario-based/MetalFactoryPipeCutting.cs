using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class MetalFactoryPipeCutting
    {
            static void Main()
        {
            Console.WriteLine("=== Metal Factory Pipe Cutting ===");
            Console.WriteLine();

            //price chart
            int[] prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
            int rodLength = 8;

            //Scenario A
            Console.WriteLine("=== Scenario A: Optimal Cutting ===");
            DisplayPriceChart(prices);
            Console.WriteLine("Rod length: " + rodLength);
            Console.WriteLine();

            int maxRevenue = FindMaxRevenue(prices, rodLength);
            Console.WriteLine("Maximum revenue: $" + maxRevenue);
            ShowCuttingStrategy(prices, rodLength);
            Console.WriteLine();

            //Scenario B
            Console.WriteLine("=== Scenario B: Custom Order Impact ===");
            Console.WriteLine("Customer wants length 6 pieces at higher price");
            prices[6] = 22; //updated price for length 6
            Console.WriteLine("Updated price for length 6 to $22");

            int newRevenue = FindMaxRevenue(prices, rodLength);
            Console.WriteLine("New maximum revenue: $" + newRevenue);
            Console.WriteLine("Revenue increase: $" + (newRevenue - maxRevenue));
            ShowCuttingStrategy(prices, rodLength);
            Console.WriteLine();

            //Scenario C
            Console.WriteLine("=== Scenario C: Unoptimized vs Optimized ===");
            int unoptimizedRevenue = GetUnoptimizedRevenue(prices, rodLength);
            Console.WriteLine("Unoptimized revenue (all 1-length cuts): $" + unoptimizedRevenue);
            Console.WriteLine("Optimized revenue: $" + newRevenue);
            Console.WriteLine("Lost revenue without optimization: $" + (newRevenue - unoptimizedRevenue));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

            static int FindMaxRevenue(int[] prices, int rodLength)
            {
                int[] dp = new int[rodLength + 1];

                for (int i = 1; i <= rodLength; i++)
                {
                    for (int j = 1; j <= i && j < prices.Length; j++)
                    {
                        dp[i] = Math.Max(dp[i], prices[j] + dp[i - j]);
                    }
                }

                return dp[rodLength];
            }

          
            static void ShowCuttingStrategy(int[] prices, int rodLength)
            {
                int[] dp = new int[rodLength + 1];
                int[] cuts = new int[rodLength + 1];

                for (int i = 1; i <= rodLength; i++)
                {
                    for (int j = 1; j <= i && j < prices.Length; j++)
                    {
                        if (dp[i] < prices[j] + dp[i - j])
                        {
                            dp[i] = prices[j] + dp[i - j];
                            cuts[i] = j;
                        }
                    }
                }

                Console.WriteLine("Best cutting strategy:");
                int remaining = rodLength;
                while (remaining > 0)
                {
                    int cut = cuts[remaining];
                    Console.WriteLine("Cut length " + cut + " for price $" + prices[cut]);
                    remaining -= cut;
                }
            }

            static int GetUnoptimizedRevenue(int[] prices, int rodLength)
            {
                return rodLength * prices[1];
            }

            static void DisplayPriceChart(int[] prices)
            {
                Console.WriteLine("Price Chart:");
                for (int i = 1; i < prices.Length; i++)
                {
                    Console.WriteLine("Length " + i + ": $" + prices[i]);
                }
            }
        
    }
}
