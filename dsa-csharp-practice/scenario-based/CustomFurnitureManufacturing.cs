using System;

namespace CG_Practice.dsascenario
{
    class CustomFurnitureManufacturing
    {
        static void Main()
        {
            Console.WriteLine("=== Custom Furniture Manufacturing ===");
            Console.WriteLine();
            int[] prices = { 0, 2, 5, 9, 6, 10, 17, 17, 20, 24, 30, 35, 40 };
            int rodLength = 12;

            //Scenario A
            Console.WriteLine("=== Scenario A: Maximum Earnings for 12ft Rod ===");
            DisplayPriceChart(prices);
            Console.WriteLine("Rod length: " + rodLength + " ft");
            Console.WriteLine();

            int maxRevenue = FindMaxRevenue(prices, rodLength);
            Console.WriteLine("Maximum revenue: $" + maxRevenue);
            ShowCuttingStrategy(prices, rodLength);
            Console.WriteLine();

            //Scenario B
            Console.WriteLine("=== Scenario B: With Waste Constraint (Max 2ft waste) ===");
            int maxWaste = 2;
            int revenueWithConstraint = FindRevenueWithWasteConstraint(prices, rodLength, maxWaste);
            Console.WriteLine("Revenue with waste constraint: $" + revenueWithConstraint);
            ShowConstrainedCuttingStrategy(prices, rodLength, maxWaste);
            Console.WriteLine();

            //Scenario C
            Console.WriteLine("=== Scenario C: Balanced Revenue and Minimal Waste ===");
            FindBalancedCuts(prices, rodLength);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //find max revenue
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
            
            Console.WriteLine("Optimal cutting strategy:");
            int remaining = rodLength;
            while (remaining > 0)
            {
                int cut = cuts[remaining];
                Console.WriteLine("Cut " + cut + "ft piece for $" + prices[cut]);
                remaining -= cut;
            }
        }

        //find revenue
        static int FindRevenueWithWasteConstraint(int[] prices, int rodLength, int maxWaste)
        {
            int bestRevenue = 0;
            
            for (int waste = 0; waste <= maxWaste; waste++)
            {
                int usableLength = rodLength - waste;
                if (usableLength > 0)
                {
                    int revenue = FindMaxRevenue(prices, usableLength);
                    bestRevenue = Math.Max(bestRevenue, revenue);
                }
            }
            
            return bestRevenue;
        }
        static void ShowConstrainedCuttingStrategy(int[] prices, int rodLength, int maxWaste)
        {
            int bestRevenue = 0;
            int bestUsableLength = 0;
            
            for (int waste = 0; waste <= maxWaste; waste++)
            {
                int usableLength = rodLength - waste;
                if (usableLength > 0)
                {
                    int revenue = FindMaxRevenue(prices, usableLength);
                    if (revenue > bestRevenue)
                    {
                        bestRevenue = revenue;
                        bestUsableLength = usableLength;
                    }
                }
            }
            
            Console.WriteLine("Best strategy with constraint:");
            Console.WriteLine("Use " + bestUsableLength + "ft, waste " + (rodLength - bestUsableLength) + "ft");
            ShowCuttingStrategy(prices, bestUsableLength);
        }
        
        static void FindBalancedCuts(int[] prices, int rodLength)
        {
            int maxRevenue = FindMaxRevenue(prices, rodLength);
            
            Console.WriteLine("Revenue vs Waste analysis:");
            for (int waste = 0; waste <= 3; waste++)
            {
                int usableLength = rodLength - waste;
                if (usableLength > 0)
                {
                    int revenue = FindMaxRevenue(prices, usableLength);
                    double efficiency = (double)revenue / usableLength;
                    Console.WriteLine("Waste " + waste + "ft: Revenue $" + revenue + 
                                    ", Efficiency $" + efficiency.ToString("F2") + "/ft");
                }
            }
        }

        static void DisplayPriceChart(int[] prices)
        {
            Console.WriteLine("Price Chart:");
            for (int i = 1; i < prices.Length; i++)
            {
                Console.WriteLine(i + "ft: $" + prices[i]);
            }
        }
    }
}