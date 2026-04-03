using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FitnessTracker
{
    public class UserStats
    {
        public string UserName;
        public int Steps;

        public UserStats(string name, int steps)
        {
            UserName = name;
            Steps = steps;
        }
    }
}
