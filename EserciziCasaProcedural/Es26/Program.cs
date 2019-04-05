using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero di cui vuoi avere il fattoriale");
            int numero =Convert.ToInt32(Console.ReadLine());
            int fattoriale = 1;
            for (int i = 1; i <= numero; i++)
            {
                fattoriale = fattoriale * i;
            }
            Console.WriteLine($"Il fattoriale di {numero} è: {fattoriale}");
            Console.Read();

            //Alternativa while

            //while (numero>0)
            //{
            //    fattoriale = fattoriale * numero;
            //    numero--;
            //}
            //Console.WriteLine($"Il fattoriale di {numero} è: {fattoriale}");
            //Console.Read();
        }
    }
}
