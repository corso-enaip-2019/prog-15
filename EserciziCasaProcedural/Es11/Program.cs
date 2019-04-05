using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci esponente");
            int esponente = Convert.ToInt32(Console.ReadLine());

            int risultato = numero;
            int esponentePerStampa = esponente;

            while (esponente > 1)
            {
                risultato = risultato * numero;
                esponente--;
            }
            Console.WriteLine($"La potenza di {numero} alla {esponentePerStampa} è: {risultato}");
            Console.Read();
        }
    }
}
