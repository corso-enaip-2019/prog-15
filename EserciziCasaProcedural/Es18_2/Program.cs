using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMax = 0;
            int numeroMin = 0;
            int numeroInserito;
            int totale = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"inserisci il nnumero {i + 1}-esimo");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                totale = totale + numeroInserito;
                if (numeroMax < numeroInserito)
                {
                    numeroMax = numeroInserito;
                }
                numeroMin = numeroInserito;
                if (true)
                {

                }
            }
            Console.WriteLine($"Numero massimo inserito: {numeroMax}\r\nLa media è: {totale/10}");

            Console.ReadLine();
        }
    }
}
