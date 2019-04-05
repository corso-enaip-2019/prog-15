using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroDaIndovinare = CreaNumeroCasuale(1, 10);

            Console.WriteLine("Indovina un numero fra 1 e 10");
            int numeroInserito = Convert.ToInt32(Console.ReadLine());

            int tentativo = IndovinaNumero(numeroInserito, numeroDaIndovinare);

            Risultato(tentativo, numeroDaIndovinare);
           

            Console.Read();
        }
        static int CreaNumeroCasuale(int min, int max)
        {
            Random numeroCasuale = new Random();
            int numeroDaIndovinare = numeroCasuale.Next(min, max);
            return numeroDaIndovinare;
        }

        static int IndovinaNumero(int numeroInserito, int numeroDaIndovinare)
        {
            int tentativo = 1;
            while (numeroInserito != numeroDaIndovinare && tentativo < 5)
            {
                Console.WriteLine("il numero non è corretto, ritenta sarai più fortunato");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                tentativo++;
            }
            return tentativo;
        }

        static void Risultato(int tentativo, int numeroDaIndovinare)
        {
            if (tentativo < 5 )
            {
                Console.WriteLine($"Hai indovinato, il numero era proprio: {numeroDaIndovinare}");
            }
            else Console.WriteLine($"Game over, il numero da indovinare era: {numeroDaIndovinare}");
        }
    }
}
