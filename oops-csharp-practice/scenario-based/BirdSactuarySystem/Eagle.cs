using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    class Eagle : Bird, IFlyable
    {
        public Eagle(string name, string colour, int age, double weight) : base(name, colour, age, weight)
        {
        }
        public void Fly()
        {
            Console.WriteLine(name + " the eagle is flying high in the sky");
        }

    }
}

