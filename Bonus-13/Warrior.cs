using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Warrior:GameCharacter
    {
        public string WeaponType { get; set; }
        public Warrior(string name, int strength, int intelligence,string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, and an intelligence of {Intelligence}.\nThe {WeaponType} is the weapon of choice for {Name}.");

        }
    }
}
