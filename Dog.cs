using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_sharp_exercises
{
    class Dog : Animal
    {
        
        public Dog(string name) 
        {
            this.Name = name;
            this.Sound = sound;
        }
        //public void MakeSound()
        //{
        //    Console.WriteLine($"{name} goes woof");
        //}

        private static readonly string sound = "woof";
    }
}
