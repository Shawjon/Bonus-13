using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter Aragorn = new Warrior("Aragorn", 10, 11, "Long sword");
            GameCharacter Legoloas = new Warrior("Legolas", 10, 11, "Bow");
            GameCharacter Gandalf = new Wizard ("Gandalf", 10, 10, 10, 9);
            GameCharacter Sauramon = new Wizard("Sauramon", 8, 9, 7, 4);
            GameCharacter Radagast = new Wizard("Radagast", 5, 10, 5, 3);

           

            GameCharacter[] gameCharacters = { Aragorn, Legoloas, Gandalf,Sauramon,Radagast };
            foreach (GameCharacter item in gameCharacters)
            {
                item.Play();
                Console.WriteLine();
            }


        }
    }
}
