using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_sharp_exercises
{
    class Parrot : Animal
    {
        public Parrot(string name)
        {
            this.Name = name;
            this.Sound = sound;
        }
        private static readonly string sound = "papuga";
    }
}
