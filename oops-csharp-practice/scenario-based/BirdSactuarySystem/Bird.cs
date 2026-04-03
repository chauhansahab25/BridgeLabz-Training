using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
    public class Bird
    {
        public string name;
        public string colour;
        public int age;
        public double weight;

        public Bird(string birdname, string birdcolour, int  birdage, double birdweight)
        {
            name = birdname;
            colour = birdcolour;
            age = birdage;
            weight = birdweight;

        }
        public void showinfo()
        {
            Console.WriteLine("Bird: " + name + " | Colour: " + colour + " | Age: " + age + " | Weight: " + weight + "Kg");
        }

    }

}
