using System;

namespace CG_Practice.oopsscenario.SmartHomeAutomationSystem
{
    
    abstract class Appliance : IControllable
    {
        public string Name;
        public bool IsOn;
        public string Location;

        public Appliance(string name, string location)
        {
            Name = name;
            Location = location;
            IsOn = false;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public void DisplayStatus()
        {
            Console.WriteLine(Name + " in " + Location + " is " + (IsOn ? "ON" : "OFF"));
        }
    }
}