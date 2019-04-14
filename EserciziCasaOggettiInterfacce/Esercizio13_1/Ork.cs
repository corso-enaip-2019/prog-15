using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13_1
{
    class Ork : ICharacter
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Strength { get { return 6; } }

        public Ork(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public void Attack(ICharacter c)
        {
            c.Power = c.Power - Strength;
            if (c.Power<0)
            {
                c.Power = 0;
            }
        }

    }
}
