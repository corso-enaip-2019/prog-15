using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13_1
{
    class Wizard : ICharacter
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int MaximumPower { get { return 20; } }

        public Wizard(string name, int power)
        {
            Name = name;
            Power = power;
        }

        Random rnd = new Random();
        public void Attack(ICharacter c)
        {
            c.Power = c.Power - (int)(MaximumPower * (1d/(rnd.Next(0,10))));
            if (c.Power < 0)
            {
                c.Power = 0;
            }
        }
    }
}
