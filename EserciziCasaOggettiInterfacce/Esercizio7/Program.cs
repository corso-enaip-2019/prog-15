using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> righeDiNumeriInvertiti = new List<List<int>>();

            Console.WriteLine("Quante righe vuoi stampare)");
            int righe = Convert.ToInt32(Console.ReadLine());

            List<List<int>> righeDiNumeri = CreaLista(righe);

            StampaLista(righeDiNumeri);

            StampaListaInvertita(righeDiNumeri);

            StampaListaEListaInvertita(righeDiNumeri);


            Console.Read();
        }

        static List<List<int>> CreaLista(int righe)
        {
            List<List<int>> righeDiNumeri = new List<List<int>>();
            for (int i = 0; i <= righe; i++)
            {
                List<int> numeri = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    numeri.Add(j + 1);
                }
                righeDiNumeri.Add(numeri);
            }
            return righeDiNumeri;
        }

        static void StampaLista(List<List<int>> righeDiNumeri)
        {
            Console.Write("Lista di numeri");
            foreach (var r in righeDiNumeri)
            {
                foreach (var n in r)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void StampaListaInvertita(List<List<int>> righeDiNumeri)
        {
            Console.Write("Lista di numeri invertiti");
            foreach (var r in righeDiNumeri)
            {
                r.Reverse();
                foreach (var n in r)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void StampaListaEListaInvertita(List<List<int>> righeDiNumeri)
        {
            StampaLista(righeDiNumeri);
            Console.WriteLine();
            StampaListaInvertita(righeDiNumeri);
        }
    }
}
