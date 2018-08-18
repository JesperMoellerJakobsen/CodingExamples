using AnimalExample.Animals;
using System;
using System.Collections.Generic;

namespace AnimalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalContainer = new List<Animal>()
            {
                new Dog(),
                new Cat(),
                new Fish()
            };

            foreach (Animal animal in animalContainer)
            {
                animal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}
