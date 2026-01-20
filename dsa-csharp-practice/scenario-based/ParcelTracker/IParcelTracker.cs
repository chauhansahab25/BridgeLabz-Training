using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.dsascenario.ParcelTrackerApp{
    interface IParcelTracker
    {
        void AddStage(string stage);
        void AddCheckpoint(string afterStage, string newStage);
        void TrackForward();
        void MarkLost(string stage);
    }
}
