using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età");
            int eta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il lavoro");
            string lavoro = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nome: {nome}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cognome: {cognome}");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"nEtà: {eta}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Lavoro: {lavoro}");

            Console.ReadLine();
        }
    }
}
