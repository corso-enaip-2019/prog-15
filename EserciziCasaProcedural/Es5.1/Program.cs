using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            double primoNumero = VerificaSeNumero();
            

            Console.WriteLine("Inserisci secondo numero");
            double secondoNumero = VerificaSeNumero();

            Console.WriteLine($"{primoNumero} + {secondoNumero} = {primoNumero + secondoNumero}");

            Console.WriteLine($"{primoNumero} - {secondoNumero} = {primoNumero - secondoNumero}");

            Console.WriteLine($"{primoNumero} * {secondoNumero} = {primoNumero * secondoNumero}");

            if (secondoNumero == 0)
            {
                Console.WriteLine("Non è possibile dividere un numero per zero");
            }
            else
            {
                Console.WriteLine($"{primoNumero} / {secondoNumero} = {primoNumero / secondoNumero}");
            }



            Console.ReadLine();
        }
        static double VerificaSeNumero()
        {
            string numeroInStringa = Console.ReadLine();
            if (double.TryParse(numeroInStringa, out double numero) == false)
            {
                Console.WriteLine("non hai inserito un valore valido");
                numero = -1;
            }
            return numero;
        }
    }
}