using System;

namespace CG_Practice.oopsscenario.FitTrackFitnessTracker
{
    // interface for trackable activities
    interface ITrackable
    {
        void StartWorkout();
        void EndWorkout();
        double CalculateCaloriesBurned();
        void DisplayProgress();
    }
}