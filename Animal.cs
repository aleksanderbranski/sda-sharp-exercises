using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_sharp_exercises
{
    class Animal
    {
        public string Name { get; set; }

        public string Sound { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} goes {Sound}");
        }

    
    }
}
