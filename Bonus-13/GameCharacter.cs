using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
       


        public GameCharacter(string name, int strength, int intelligence )
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        

        public virtual void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, and an intelligence of {Intelligence}.");
        }
    }
}
