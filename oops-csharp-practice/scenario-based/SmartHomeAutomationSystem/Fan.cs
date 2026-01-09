using System;

namespace CG_Practice.oopsscenario.SmartHomeAutomationSystem
{
    
    class Fan : Appliance
    {
        public int Speed;

        public Fan(string name, string location) : base(name, location)
        {
            Speed = 0;
        }

        public override void TurnOn()
        {
            IsOn = true;
            Speed = 1;
            Console.WriteLine(Name + " turned ON at speed " + Speed);
        }

        public override void TurnOff()
        {
            IsOn = false;
            Speed = 0;
            Console.WriteLine(Name + " turned OFF");
        }

        public void SetSpeed(int level)
        {
            if (IsOn && level >= 1 && level <= 5)
            {
                Speed = level;
                Console.WriteLine(Name + " speed set to " + level);
            }
        }
    }
}