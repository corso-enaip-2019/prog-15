using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es23_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Inserisci primo numero");
                double primoNumero =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci secondo numero");
                double secondoNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci operazione da eseguire(+,-,*,/)");
                string operazione = Console.ReadLine();

                switch (operazione)
                {
                    case "+": Console.WriteLine($"{primoNumero} + {secondoNumero} = {primoNumero+secondoNumero}");
                        break;

                    case "-":
                        Console.WriteLine($"{primoNumero} - {secondoNumero} = {primoNumero - secondoNumero}");
                        break;

                    case "*":
                        Console.WriteLine($"{primoNumero} * {secondoNumero} = {primoNumero * secondoNumero}");
                        break;

                    case "/":
                        if (secondoNumero == 0)
                        {
                            Console.WriteLine("Non è possibile eseguire una divisione per zero");
                        }
                        else
                        {
                            Console.WriteLine($"{primoNumero} / {secondoNumero} = {primoNumero / secondoNumero}");
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
