using System;

namespace CG_Practice.oopsscenario.MetalFactoryPipeCutting
{
    // main pipe cutting class
    class PipeCutter
    {
        private int[] prices;
        private int rodLength;

        public PipeCutter(int[] priceChart, int length)
        {
            prices = priceChart;
            rodLength = length;
        }

        // find best revenue using dynamic programming
        public int FindMaxRevenue()
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

        // show cutting strategy
        public void ShowCuttingStrategy()
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
                Console.WriteLine("Cut length " + cut + " for price " + prices[cut]);
                remaining -= cut;
            }
        }

        // calculate revenue without optimization
        public int GetUnoptimizedRevenue()
        {
            // just cut into pieces of length 1
            return rodLength * prices[1];
        }

        public void UpdatePrice(int length, int newPrice)
        {
            if (length < prices.Length)
            {
                prices[length] = newPrice;
                Console.WriteLine("Updated price for length " + length + " to " + newPrice);
            }
        }

        public void DisplayPriceChart()
        {
            Console.WriteLine("Price Chart:");
            for (int i = 1; i < prices.Length; i++)
            {
                Console.WriteLine("Length " + i + ": $" + prices[i]);
            }
        }
    }
}