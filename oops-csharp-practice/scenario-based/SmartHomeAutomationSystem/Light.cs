using System;

namespace CG_Practice.oopsscenario.SmartHomeAutomationSystem
{
    
    class Light : Appliance
    {
        public int Brightness;

        public Light(string name, string location) : base(name, location)
        {
            Brightness = 0;
        }

        public override void TurnOn()
        {
            IsOn = true;
            Brightness = 100;
            Console.WriteLine(Name + " turned ON with brightness " + Brightness + "%");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Brightness = 0;
            Console.WriteLine(Name + " turned OFF");
        }

        public void SetBrightness(int level)
        {
            if (IsOn)
            {
                Brightness = level;
                Console.WriteLine(Name + " brightness set to " + level + "%");
            }
        }
    }
}