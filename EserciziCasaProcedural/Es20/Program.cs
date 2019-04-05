using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es20
{
    class Program
    {
        static void Main(string[] args)
        {
            int contatore = 1;
            int numero = 1;
            while (contatore < 100)
            {
                if (isPrime(numero) && isPalindrome(numero))
                {
                    Console.WriteLine($"{numero} è primo ed è palindromo");
                    numero++;
                    contatore++;
                }
                else if (isPrime(numero) && !isPalindrome(numero))
                {
                    Console.WriteLine($"{numero} è primo ma NON è palindromo");
                    numero++;
                    contatore++;
                }
                else
                    numero++;
            }

            Console.Read();
        }
        public static bool isPrime(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        public static bool isPalindrome(int numero)
        {
            char[] numeroChar = numero.ToString().ToCharArray();
            for (int i = 0; i < numeroChar.Length; i++)
            {
                if (numeroChar[i] != numeroChar[(numeroChar.Length-1) - i])

                    return false;
                
            }
            return true;
            
        }
    }

}
