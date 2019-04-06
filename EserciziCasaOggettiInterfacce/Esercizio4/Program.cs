using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch testCalculatePrimeNumbers = new Stopwatch();
            testCalculatePrimeNumbers.Start();

            List<int> primeNumbers = CalculatePrimeNumbers(10000); 

            testCalculatePrimeNumbers.Stop();
            TimeSpan time = testCalculatePrimeNumbers.Elapsed;

            Stopwatch testWritePrimeNumbers = new Stopwatch();
            testWritePrimeNumbers.Start();

            foreach (int primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
            testWritePrimeNumbers.Stop();
            TimeSpan time2 = testWritePrimeNumbers.Elapsed;

            Console.WriteLine($"Tempo per calcolare i numeri primi: {time}");
            Console.WriteLine($"Tempo per stampare i numeri primi: {time2}");


            Console.Read();
        }

        public static List<int> CalculatePrimeNumbers(int numMax)
        {
            List<int> primeNumbers = new List<int>();
            int number = 2;
            while (number < numMax)
            {
                if (isPrime(number))
                {
                    primeNumbers.Add(number);
                    number++;
                }
                else
                    number++;
            }
            return primeNumbers;
        }

        public static bool isPrime(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
