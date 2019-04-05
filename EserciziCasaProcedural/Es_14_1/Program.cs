using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primoNumero = 0;
            int secondoNumero = 1;
            int terzoNumero=0;
            while (terzoNumero < 1000)
            {
                Console.Write($"{terzoNumero} ");
                terzoNumero = primoNumero + secondoNumero;
                primoNumero = secondoNumero;
                secondoNumero = terzoNumero;
                
            }
            Console.ReadLine();
        }
    }
}
