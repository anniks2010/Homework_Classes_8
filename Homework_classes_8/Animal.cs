using System;

namespace Homework_classes_8
{
    internal class Animal
    {
        public string Name;
        public int Age = 0;
        public double Weight;
        public int LIfeSpan = 0;

        public void ToPrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Age is {Age}");
            Console.WriteLine($"Weight is {Weight}");
            Console.WriteLine($"Lifespan is {LIfeSpan}");

        }
        public void ToEat()
        {
            Console.WriteLine("Eating");
            Weight += 0.2;
        }
        public void ToDoExcerices()
        {
            Console.WriteLine("Running");
            Weight -= 0.1;
        }
        
    }
}
