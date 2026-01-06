using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    class Penguin : Bird , ISwimmable
    {
        public Penguin(string name, string colour ,int age , double weight) : base(name,colour,age,weight)
        {

        }
        public void swim()
        {
            Console.WriteLine(name + " the penguin is swimming underwater ");
        }
    }
}
