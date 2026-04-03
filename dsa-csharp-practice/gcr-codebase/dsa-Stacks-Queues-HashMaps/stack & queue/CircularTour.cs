using System;

namespace CG_Practice.dsacsharp
{
    public class CircularTour
    {
        public int FindStartingPoint(int[] petrol, int[] dist)
        {
            int n = petrol.Length;
            int start = 0, deficit = 0, tank = 0;

            for (int i = 0; i < n; i++)
            {
                tank += petrol[i] - dist[i];
                if (tank < 0)
                {
                    deficit += tank;
                    tank = 0;
                    start = i + 1;
                }
            }
            return tank + deficit >= 0 ? start : -1;
        }
    }
}