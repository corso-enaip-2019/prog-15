using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primoNumero = 0;
            int secondoNumero = 1;
            int terzoNumero = 0;
            int somma = 0;
            while (somma < 100000)
            {
                Console.Write($"{terzoNumero} ");
                terzoNumero = primoNumero + secondoNumero;
                primoNumero = secondoNumero;
                secondoNumero = terzoNumero;
                somma = somma + terzoNumero;

            }
            Console.ReadLine();
        }
    }
}
