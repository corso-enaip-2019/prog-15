using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es28
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero = 600851475143;
            long fattorePrimo = 2;
            while (!isPrime(numero))
            {
                if (numero%fattorePrimo == 0)
                {
                    Console.Write($"{fattorePrimo} ");
                    numero = numero / fattorePrimo;
                }
                else
                {
                    fattorePrimo++;
                }
                

            }
            Console.Write($"{numero} ");
            Console.Read();
        }




        public static bool isPrime(long numero)
        {
            for (long i = 2; i < numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
