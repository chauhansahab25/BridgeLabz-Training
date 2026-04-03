using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FitnessTracker
{
    public class RunFitnessApp
    {
        public static void Main(string[] args)
        {
            IFitnessManager tracker = new FitnessManagerImpl();
            bool running = true;

            Console.WriteLine("=== FITNESS TRACKER ===");

            while (running)
            {
                FitnessUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string name = FitnessUtility.GetString("User Name");
                        int steps = FitnessUtility.GetInt("Steps Today");
                        tracker.LogUserSteps(name, steps);
                        break;
                    case "2":
                        tracker.UpdateRankings();
                        break;
                    case "3":
                        tracker.UpdateRankings();
                        tracker.ShowLeaderboard();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}
