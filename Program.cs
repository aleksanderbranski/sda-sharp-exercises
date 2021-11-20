using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Mruczek");
          //  cat1.MakeSound();

            Dog dog1 = new Dog("Burek");
            //  dog1.MakeSound();

  

            List<Animal> animals = new List<Animal>();

            animals.Add(cat1);
            animals.Add(dog1);


            foreach (Animal a in animals)
            {
                a.MakeSound();
                Console.WriteLine($"It's a {a.GetType().Name}");

                if (a is not Cat && a is not Dog)
                {
                    Console.WriteLine("We don't know!");
                }
            }

        }
    }
}
