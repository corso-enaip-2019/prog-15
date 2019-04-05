using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2000000000;
            int b = 2000000000;
            int sommaErrata = a + b;

            Console.WriteLine(sommaErrata);
            Console.WriteLine("somma errata");
            Console.WriteLine();

            long c = (int)a;
            long d = (int)b;
            long sommaCorretta = c + d;

            Console.WriteLine(sommaCorretta);
            Console.WriteLine("restituisce valore corretto");

            Console.Read();
        }
    }
}
