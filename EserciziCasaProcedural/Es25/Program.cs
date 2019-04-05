using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es25
{
    class Program
    {
        static void Main(string[] args)
        {
            double lato1, lato2;
            string opzioneLato = "";
            Console.WriteLine("Dammi due lati di un triangolo rettangolo e calcolerò il terzo");

            Console.WriteLine("\r\nIl lato che stai inserendo è un cateto(scrivi 's' per si 'n' per no)");
            opzioneLato = Console.ReadLine();
            Console.WriteLine("inserisci il valore del lato");
            lato1 = Convert.ToInt32(Console.ReadLine());

            if (opzioneLato == "s")
            {
                Console.WriteLine("\r\nIl lato che stai inserendo è un cateto(scrivi 'c') o un'ipotenusa(scrivi 'i')");
                opzioneLato = Console.ReadLine();
                Console.WriteLine("inserisci il valore del lato");
                lato2 = Convert.ToInt32(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("inserisci il valore del lato");
                lato2 = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
