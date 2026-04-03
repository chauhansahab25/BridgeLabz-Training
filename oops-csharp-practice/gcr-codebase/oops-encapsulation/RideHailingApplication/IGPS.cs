using System;

namespace CG_Practice.oopscsharp.RideHailingApplication
{
    // interface for GPS operations
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }
}