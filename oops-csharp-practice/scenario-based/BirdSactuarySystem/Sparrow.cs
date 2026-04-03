using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name, string colour, int age, double weight) : base(name, colour, age, weight)
        {

        }
        public void Fly()
        {
            Console.WriteLine(name + " the sparrow is flying quickly");
        }



    }
}
