using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.scenariobased
{
        public class WeatherStats
        {
            static int[,] hourlyTemps = new int[7, 24]
            {
            { 30, 29, 29, 28, 28, 29, 21, 23, 25, 27, 29, 31, 33, 34, 34, 33, 32, 30, 28, 27, 25, 24, 23, 22 },
            { 25, 20, 19, 19, 18, 18, 20, 22, 24, 26, 28, 30, 32, 33, 33, 32, 31, 29, 27, 26, 25, 24, 23, 22 },
            { 21, 20, 20, 19, 19, 20, 22, 24, 26, 29, 31, 33, 35, 36, 36, 35, 33, 31, 29, 28, 26, 25, 24, 23 },
            { 22, 21, 21, 20, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 29, 28, 27, 26, 25, 24, 23, 22, 21, 21 },
            { 20, 19, 18, 18, 17, 18, 20, 22, 25, 28, 30, 32, 34, 35, 35, 34, 32, 30, 28, 26, 24, 23, 22, 21 },
            { 21, 20, 19, 19, 18, 19, 21, 23, 26, 28, 30, 32, 33, 34, 34, 33, 31, 29, 27, 26, 25, 23, 22, 21 },
            { 20, 19, 19, 18, 18, 19, 21, 24, 26, 29, 31, 33, 35, 36, 35, 34, 32, 30, 28, 27, 25, 24, 23, 22 }
            };

            public static int[] CalculateDailyMeans(int[,] data)
            {
                int daySum = 0;
                int dayAvg = 0;
                int[] results = new int[7];

                for (int d = 0; d < 7; d++)
                {
                    for (int h = 0; h < 24; h++)
                    {
                        daySum = daySum + data[d, h];
                    }
                    dayAvg = daySum / 24;
                    results[d] = dayAvg;

                    daySum = 0;
                    dayAvg = 0;
                }

                return results;
            }

            public static String FindExtremes(int[] dailyData)
            {
                int highVal = int.MinValue;
                int lowVal = int.MaxValue;

                int CoolDayIndex = 10;
                int HotDayIndex = 10;

                for (int k = 0; k < 7; k++)
                {
                    if (dailyData[k] < lowVal)
                    {
                        lowVal = dailyData[k];
                        CoolDayIndex = k;
                    }
                    if (dailyData[k] > highVal)
                    {
                        highVal = dailyData[k];
                        HotDayIndex = k;
                    }
                }

                return "Highest Avg: " + highVal + "°C (Day " + (HotDayIndex + 1) + ")\n" +
                       "Lowest Avg: " + lowVal + "°C (Day " + (CoolDayIndex + 1) + ")";
            }

            public static void RunMenu()
            {
                bool Going = true;

                while (Going)
                {
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("          WEATHER DATA TRACKER            ");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("1. View Daily Average Temperatures");
                    Console.WriteLine("2. Find Hottest and Coldest Days");
                    Console.WriteLine("3. Show Raw Hourly Data (Preview)");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Select Option (1-4): ");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("\n--- Average Temps Per Day ---");
                            int[] means = CalculateDailyMeans(hourlyTemps);
                            for (int i = 0; i < means.Length; i++)
                            {
                                Console.WriteLine($"Day {i + 1}: {means[i]}°C");
                            }
                            break;

                        case "2":
                            Console.WriteLine("\n--- Highs and Lows ---");
                            int[] dataPoints = CalculateDailyMeans(hourlyTemps);
                            Console.WriteLine(FindExtremes(dataPoints));
                            break;

                        case "3":
                            Console.WriteLine("\n--- Hourly Preview (First 5 Hours) ---");
                            for (int r = 0; r < 7; r++)
                            {
                                Console.Write($"Day {r + 1}: ");
                                for (int c = 0; c < 5; c++)
                                {
                                    Console.Write(hourlyTemps[r, c] + " ");
                                }
                                Console.WriteLine("...");
                            }
                            break;

                        case "4":
                            Going = false;
                            Console.WriteLine("Closing application...");
                            break;

                        default:
                            Console.WriteLine("Invalid selection. Try again.");
                            break;
                    }
                }
            }

            public static void Main(String[] args)
            {
                RunMenu();
            }
        }
}

