using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.BirdSanctuarySystem
{
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ECOWING WILDLIFE CONSERVATION CENTER ===");
                Console.WriteLine();

                // create array of different birds
                Bird[] birds = new Bird[5];
                birds[0] = new Eagle("Taj", "Brown", 5, 4.5);
                birds[1] = new Sparrow("katto", "Gray", 2, 0.03);
                birds[2] = new Duck("Donald Duck", "Yellow", 3 ,1.2);
                birds[3] = new Penguin("Skipper", "Black-White", 4, 25.0);
                birds[4] = new Seagull("Scuttle", "White", 3, 0.8);

                Console.WriteLine("=== BIRD SANCTUARY ACTIVITIES ===");

                // check each bird and call appropriate methods
                for (int i = 0; i < birds.Length; i++)
                {
                    birds[i].showinfo();

                    // check if bird can fly
                    if (birds[i] is IFlyable)
                    {
                        IFlyable flyingBird = (IFlyable)birds[i];
                        flyingBird.Fly();
                    }

                    // check if bird can swim
                    if (birds[i] is ISwimmable)
                    {
                        ISwimmable swimmingBird = (ISwimmable)birds[i];
                        swimmingBird.swim();
                    }

                    Console.WriteLine("------------------------");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    

}
