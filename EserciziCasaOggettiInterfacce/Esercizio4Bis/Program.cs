using System;
using System.Diagnostics;

namespace Esercizio4Bis
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePrimeNumbersAndTime(1000000);

            Console.Read();
        }

        public static void CalculatePrimeNumbersAndTime(int numMax)
        {
            Stopwatch testCalculatePrimeNumbers = new Stopwatch();

            int number = 2;
            int numberPrime;
            while (number < numMax)
            {

                testCalculatePrimeNumbers.Start();
                if (isPrime(number))
                {
                    numberPrime = number;
                    number++;
                    testCalculatePrimeNumbers.Stop();
                    TimeSpan time = testCalculatePrimeNumbers.Elapsed;
                    Console.WriteLine($"{numberPrime} - {time.TotalMilliseconds}");
                }
                else
                    number++;


            }
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
    class TempiIntermedi
    {
        public int PrimeNumber { get; set; }
        public TimeSpan TempoIntermedio { get; set; }
    }
}
