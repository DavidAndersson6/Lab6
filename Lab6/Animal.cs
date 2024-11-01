using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Animal
    {

        public int Legs { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }


        public Animal(int legs, string name, string color, string species, int age)
        {
            Legs = legs;
            Name = name;
            Color = color;
            Species = species;
            Age = age;
        }

        public void PrintNumberOfLegs()
        {
            Console.WriteLine($"Number of legs of {Name} is {Legs}");
        }

        public void PrintColor()
        {
            Console.WriteLine($"Color of {Name} is {Color}");
        }

        public void PrintAge()
        {
            Console.WriteLine($"Age of {Name} is {Age}");
        }
    }

     public class Dog : Animal

    {
        public bool Drools { get; set; }
        public Dog(int legs, string name, string color, string species, int age, bool drools)
        : base(legs, name, color, species, age)
        {
            Drools = drools;
        }

        public virtual void MakeSound()
        {

            Console.WriteLine($"{Name} says Woof");
        }
    }

    public class Cat : Animal

    {
        public bool Whiskers { get; set; }
        public Cat(int legs, string name, string color, string species, int age, bool whiskers)
        : base(legs, name, color, species, age)
        {
            Whiskers = whiskers;
        }
        public void MakeSound()
        {

            Console.WriteLine($"{Name} says Mjau");
        }
    }

    public class Fish : Animal

    {
        public bool Predator;
        public Fish(int legs, string name, string color, string species, int age, bool predator)
        : base(legs, name, color, species, age)
        {
            Predator = predator; 
        }
        public void MakeSound()
        {

            Console.WriteLine($"{Name} says blubb");
        }
    }

    public class Bulldog : Dog
    {
        public bool Aggressive { get; set; }
        public Bulldog(int legs, string name, string color, string species, int age, bool drools, bool aggressive)
       : base(legs, name, color, species, age, drools)
        {
            Aggressive = aggressive;
        }
            public override void MakeSound()
        {
            base.MakeSound();
            if (Aggressive)
            {
                Console.WriteLine($"{Name} growls aggressively!");
            }
            else
            {
                Console.WriteLine($"{Name} barks in a friendly way!");
            }
        }


    }

    public class Chihuahua : Dog
    {
        public bool HasHair { get; set; }
        public Chihuahua(int legs, string name, string color, string species, int age, bool drools, bool hasHair)
       : base(legs, name, color, species, age, drools)
        {
            HasHair = hasHair;
        }
        public override void MakeSound()
        {
            base.MakeSound();
            if (HasHair)
            {
                Console.WriteLine($"{Name} growls happily because it has hair!");
            }
            else
            {
                Console.WriteLine($"{Name} barks in a sad way because it has no hair :( ");
            }
        }


    }

}

