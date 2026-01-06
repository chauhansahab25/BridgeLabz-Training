using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    class Duck : Bird , ISwimmable
    {
        public Duck(string name , string colour ,int age , double weight) : base(name , colour , age , weight)
        {

        }
        public void swim()
        {
            Console.WriteLine(name + " the duck is swimming in the pond");
        }
    }
}
