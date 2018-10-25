using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Wizard:MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard (string name, int strength, int intelligence, int magicalEnergy,int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, and an intelligence of {Intelligence}." +
                $"\nThey have {SpellNumber} spells left to use becuase their current magical level is at {MagicalEnergy}.");


        }

    }
}
