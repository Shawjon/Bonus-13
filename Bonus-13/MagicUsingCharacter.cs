using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string name, int strength, int intelligence,  int magicalEnergy) :base (name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }
        public override void Play()
        {
            //Play();
            Console.WriteLine($"{Name} has a strength of {Strength}, and an intelligence of {Intelligence}.");
            Console.WriteLine($"{Name} has a magical level of {MagicalEnergy}.");

        }
    }
}
