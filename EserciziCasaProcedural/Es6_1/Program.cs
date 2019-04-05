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
            int eta =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il lavoro");
            string lavoro = Console.ReadLine();

            Console.WriteLine($"\r\nNome: {nome}\r\nCognome: {cognome}\r\nEtà: {eta}\r\nLavoro: {lavoro}");

            Console.ReadLine();
        }
    }
}
