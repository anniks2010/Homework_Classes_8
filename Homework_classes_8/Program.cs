using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_classes_8
{
    class Animal
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
    class Program
    {
        static void Main(string[] args)
        {
            Animal hamster = new Animal();
            hamster.Name = "Lemon";
            hamster.Weight = 0.1;

            for (int i = 0; i < 10; i++)
            {
                hamster.LIfeSpan++;
                hamster.Age++;

                if(hamster.Weight > 0.7)
                {
                    hamster.ToDoExcerices();
                }
                else
                {
                    hamster.ToEat();
                }
            }
            
            hamster.ToPrintAnimalBaseInfo();

            if (hamster.LIfeSpan == 10)
            {
                Console.WriteLine($"Hamster {hamster.Name}, I'm sorry, you are dead, we can't help it.");
                hamster = null;
            }
            
            Console.ReadLine();
        }
    }
}
