using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FitnessTracker
{
    public interface IFitnessManager
    {
        void LogUserSteps(string name, int steps);
        void UpdateRankings();
        void ShowLeaderboard();
    }
}
