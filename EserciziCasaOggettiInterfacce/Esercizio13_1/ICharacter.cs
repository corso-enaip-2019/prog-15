using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13_1
{
    interface ICharacter
    {
        string Name { get; set; }
        int Power { get; set; }

        void Attack(ICharacter c);
    }
}
