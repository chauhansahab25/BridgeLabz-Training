using System;

namespace CG_Practice.oopsscenario.FitTrackFitnessTracker
{
    // strength workout class
    class StrengthWorkout : Workout
    {
        public int Sets;
        public int Reps;
        public double Weight;
        public string MuscleGroup;

        public StrengthWorkout(string name, string muscle) : base(name)
        {
            MuscleGroup = muscle;
            Sets = 0;
            Reps = 0;
            Weight = 0;
        }

        public void SetWorkoutDetails(int sets, int reps, double weight)
        {
            Sets = sets;
            Reps = reps;
            Weight = weight;
        }

        public override double CalculateCaloriesBurned()
        {
            // Simple calculation: 8 calories per minute for strength training
            CaloriesBurned = Duration * 8;
            return CaloriesBurned;
        }

        public override void DisplayProgress()
        {
            base.DisplayProgress();
            Console.WriteLine("Muscle Group: " + MuscleGroup);
            Console.WriteLine("Sets: " + Sets);
            Console.WriteLine("Reps: " + Reps);
            Console.WriteLine("Weight: " + Weight + " kg");
        }
    }
}