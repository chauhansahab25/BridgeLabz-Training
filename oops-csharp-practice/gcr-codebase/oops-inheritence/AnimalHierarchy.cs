using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base animal class
    class Animal
    {
        public string Name;  // animal name
        public int Age;      // animal age

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // virtual method - can be overridden by child classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }
    }

    // dog class inherits from animal
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)  // call parent constructor
        {
        }

        // override parent method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof! Woof!");
        }
    }

    // cat class inherits from animal
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows: Meow! Meow!");
        }
    }

    // bird class inherits from animal
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps: Tweet! Tweet!");
        }
    }

    class Program
    {
        static void Main()
        {
            // create different animals
            Dog dog = new Dog("buddy", 3);
            Cat cat = new Cat("whiskers", 2);
            Bird bird = new Bird("tweety", 1);

            // show animal info and sounds
            dog.showInfo();
            dog.MakeSound();
            Console.WriteLine();

            cat.showInfo();
            cat.MakeSound();
            Console.WriteLine();

            bird.showInfo();
            bird.MakeSound();
            Console.WriteLine();

            // polymorphism - same method different behavior
            Animal[] animals = { dog, cat, bird };
            Console.WriteLine("All animals making sounds:");
            foreach (Animal animal in animals)
            {
                animal.MakeSound();  // calls overridden method
            }

            Console.ReadLine();
        }
    }
}