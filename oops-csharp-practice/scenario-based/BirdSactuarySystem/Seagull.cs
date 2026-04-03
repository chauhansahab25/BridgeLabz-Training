using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    class Seagull : Bird ,IFlyable , ISwimmable
    {
        public Seagull(string name, string colour ,int age , double weight) : base(name, colour ,age ,weight) 
        {
        }
        public void Fly()
        {
            Console.WriteLine(name + " the seagull is flying over the ocean!");
        }
        public void swim()
        {
            Console.WriteLine(name + "Seagull is floating on water");
        }
    }
}
