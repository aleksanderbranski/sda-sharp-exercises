using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_sharp_exercises
{
    class Cat : Animal
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public Cat(string name)
        {     
        this.Name=name;
        this.Sound = sound;
        }
        //public void MakeSound()
        //{
        //    Console.WriteLine($"{Name} goes meow");
        //}

        private static readonly string sound = "meow";

    }

   
}
