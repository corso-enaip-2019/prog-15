using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero di cui vuoi conoscere il valore assoluto");

            string numeroInStringa = Console.ReadLine();
            char[] numeroInChar = numeroInStringa.ToArray();
            Console.WriteLine();

            if (numeroInChar[0] == '+' || numeroInChar[0] == '-')
            {
                Console.Write("il valore assoluto del numero è: ");
                for (int i = 1; i < numeroInChar.Length; i++)
                {
                    Console.Write(numeroInChar[i]);
                }
            }
            else
                Console.WriteLine($"il valore assoluto del numero è: {numeroInStringa}");


            Console.Read();
        }
    }
}
