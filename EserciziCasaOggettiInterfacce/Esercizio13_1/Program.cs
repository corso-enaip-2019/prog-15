using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICharacter> characters = new List<ICharacter>();
            characters.Add(new Ork("Shrek", 50));
            characters.Add(new Warrior("Massimo Decimo Meridio", 45));
            characters.Add(new Wizard("Mago Merlino", 55));

            Random rnd = new Random();

            while (characters.Count >= 1)
            {
                int randomAttack = 0, randomDefense = 0;
                while (randomAttack == randomDefense)
                {
                    randomAttack = rnd.Next(0, characters.Count);
                    randomDefense = rnd.Next(0, characters.Count);
                }
                var characterAttack = characters[randomAttack];
                var characterDefense = characters[randomDefense];

                characterAttack.Attack(characterDefense);

                Console.WriteLine($"{characterAttack.Name} ha attaccato {characterDefense.Name} (potenza rimasta: {characterDefense.Power})");
                if (characterDefense.Power <= 0)
                {
                    characters.Remove(characterDefense);
                    Console.WriteLine($"{characterDefense.Name} è morto");
                }
                if(characters.Count == 1)
                {
                    Console.WriteLine($"Il vincitore è: {characterAttack.Name}");
                }
                
            }


            Console.ReadLine();
        }
    }
}
