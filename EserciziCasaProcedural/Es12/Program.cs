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
            Console.WriteLine("Inserisci primo numero");
            int primonNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci secondo numero");
            int secondoNumero = Convert.ToInt32(Console.ReadLine());

            int risultato = 0;
            int secondoNumeroPerStampa = secondoNumero;

            while (secondoNumero>0)
            {
                risultato += primonNumero;
                secondoNumero--;
            }
            Console.WriteLine($"La moltiplicazione di {primonNumero} per {secondoNumeroPerStampa} è: {risultato}");
            Console.Read();
        }
    }
}
