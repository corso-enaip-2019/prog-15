using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13_1
{
    class Warrior : ICharacter
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public double DamagePercentage { get { return 0.10; } }

        public void Attack(ICharacter c)
        {
            if (c.Power > 5)

                c.Power = c.Power - (int)(c.Power * DamagePercentage);
            else
                c.Power = 0;

        }

        public Warrior(string name, int power)
        {
            Name = name;
            Power = power;
        }




    }
}
