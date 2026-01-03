using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base device class
    class Device
    {
        public string DeviceId;  // device identifier
        public string Status;    // device status (on/off)

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Device ID: " + DeviceId);
            Console.WriteLine("Status: " + Status);
        }
    }

    // thermostat class inherits from device (single inheritance)
    class Thermostat : Device
    {
        public int TemperatureSetting;  // additional attribute

        public Thermostat(string deviceId, string status, int temperature) 
            : base(deviceId, status)  // call parent constructor
        {
            TemperatureSetting = temperature;
        }

        // override parent method
        public override void DisplayStatus()
        {
            Console.WriteLine("Device Type: Thermostat");
            base.DisplayStatus();  // call parent method
            Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
        }
    }

    class Program
    {
        static void Main()
        {
            // create smart home devices
            Thermostat thermostat1 = new Thermostat("THERM001", "ON", 22);
            Thermostat thermostat2 = new Thermostat("THERM002", "OFF", 18);

            // display device status
            Console.WriteLine("Thermostat 1:");
            thermostat1.DisplayStatus();
            Console.WriteLine();

            Console.WriteLine("Thermostat 2:");
            thermostat2.DisplayStatus();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}