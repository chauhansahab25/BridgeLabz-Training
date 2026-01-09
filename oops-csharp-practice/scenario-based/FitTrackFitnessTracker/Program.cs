using System;

namespace CG_Practice.oopsscenario.FitTrackFitnessTracker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== FitTrack - Fitness Tracker ===");
            Console.WriteLine();

            // Create user profile
            UserProfile user = new UserProfile("John Doe", 25, 70.5, 175);
            user.SetFitnessGoal("Lose 5kg in 3 months");
            user.DisplayProfile();
            Console.WriteLine();

            // Cardio workout
            CardioWorkout cardio = new CardioWorkout("Morning Run", "Running");
            cardio.StartWorkout();
            
            Console.WriteLine("Press any key to end cardio workout...");
            Console.ReadKey();
            
            cardio.EndWorkout();
            cardio.SetDistance(5.2);
            cardio.SetSpeed(8.5);
            cardio.CalculateCaloriesBurned();
            
            Console.WriteLine();
            cardio.DisplayProgress();
            user.UpdateProgress(cardio.CaloriesBurned);
            Console.WriteLine();

            // Strength workout
            StrengthWorkout strength = new StrengthWorkout("Chest Press", "Chest");
            strength.StartWorkout();
            
            Console.WriteLine("Press any key to end strength workout...");
            Console.ReadKey();
            
            strength.EndWorkout();
            strength.SetWorkoutDetails(3, 12, 60);
            strength.CalculateCaloriesBurned();
            
            Console.WriteLine();
            strength.DisplayProgress();
            user.UpdateProgress(strength.CaloriesBurned);
            Console.WriteLine();

            // Display updated profile
            user.DisplayProfile();
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}