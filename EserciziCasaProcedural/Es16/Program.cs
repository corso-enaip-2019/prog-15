using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16
{
    class Program
    {
        static void Main(string[] args)
        {
            int cifraBinaria;
            Console.WriteLine("Inserisci il numero che vuoi trasformare in binario");
            if (int.TryParse(Console.ReadLine(),out int numero)==false)
            {
                Console.WriteLine("Non hai inserito un valore valido");
            }

            Console.Write("\r\nIl numero in binario è: ");
            while (numero >0)
            {
                cifraBinaria = numero % 2;
                numero = numero / 2;
                Console.Write(cifraBinaria);
            }
            Console.Read();
        }
    }
}
