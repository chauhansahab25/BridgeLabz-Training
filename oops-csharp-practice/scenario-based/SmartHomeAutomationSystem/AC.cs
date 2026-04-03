using System;

namespace CG_Practice.oopsscenario.SmartHomeAutomationSystem
{
    
    class AC : Appliance
    {
        public int Temperature;
        public string Mode;

        public AC(string name, string location) : base(name, location)
        {
            Temperature = 24;
            Mode = "Cool";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(Name + " turned ON - Cooling to " + Temperature + "°C in " + Mode + " mode");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(Name + " turned OFF - Saving energy");
        }

        public void SetTemperature(int temp)
        {
            if (IsOn && temp >= 16 && temp <= 30)
            {
                Temperature = temp;
                Console.WriteLine(Name + " temperature set to " + temp + "°C");
            }
        }

        public void SetMode(string mode)
        {
            if (IsOn)
            {
                Mode = mode;
                Console.WriteLine(Name + " mode set to " + mode);
            }
        }
    }
}