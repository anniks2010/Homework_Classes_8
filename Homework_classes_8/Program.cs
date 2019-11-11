using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_classes_8
{
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
