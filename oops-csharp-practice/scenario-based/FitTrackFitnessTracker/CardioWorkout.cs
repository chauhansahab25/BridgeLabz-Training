using System;

namespace CG_Practice.oopsscenario.FitTrackFitnessTracker
{
    // cardio workout class
    class CardioWorkout : Workout
    {
        public double Distance;
        public double Speed;
        public string CardioType;

        public CardioWorkout(string name, string type) : base(name)
        {
            CardioType = type;
            Distance = 0;
            Speed = 0;
        }

        public void SetDistance(double distance)
        {
            Distance = distance;
        }

        public void SetSpeed(double speed)
        {
            Speed = speed;
        }

        public override double CalculateCaloriesBurned()
        {
            // Simple calculation: 10 calories per minute for cardio
            CaloriesBurned = Duration * 10;
            return CaloriesBurned;
        }

        public override void DisplayProgress()
        {
            base.DisplayProgress();
            Console.WriteLine("Cardio Type: " + CardioType);
            Console.WriteLine("Distance: " + Distance + " km");
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }
}