using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es23_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double primoNumero = 0;
                double secondoNumero = 0;
                bool primoNumeroCorretto = false;
                Console.WriteLine("Nuova operazione:");

                while (primoNumeroCorretto == false)
                {
                    Console.WriteLine("\r\nInserisci primo numero");
                    string primoNumeroInStringa = Console.ReadLine();
                    if (Double.TryParse(primoNumeroInStringa, out primoNumero) == false)
                    {
                        Console.WriteLine("Non hai inserito un valore valido");

                    }
                    else
                        primoNumeroCorretto = true;
                }

                bool secondoNumeroCorretto = false;

                while (secondoNumeroCorretto == false)
                {
                    Console.WriteLine(("\r\nInserisci secondo numero"));
                    string secondoNumeroInStringa = Console.ReadLine();
                    if (Double.TryParse(secondoNumeroInStringa, out secondoNumero) == false)
                    {
                        Console.WriteLine("Non hai inserito un valore valido");

                    }
                    else
                        secondoNumeroCorretto = true;
                }

                bool operazioneCorretta = false;

                while (operazioneCorretta == false)
                {
                    Console.WriteLine("\r\nInserisci operazione da eseguire(+,-,*,/)");
                    string operazione = Console.ReadLine();

                    switch (operazione)
                    {
                        case "+":
                            {
                                Console.WriteLine($"{primoNumero} + {secondoNumero} = {primoNumero + secondoNumero}");
                                operazioneCorretta = true;
                            }
                            break;

                        case "-":
                            {
                                Console.WriteLine($"{primoNumero} - {secondoNumero} = {primoNumero - secondoNumero}");
                                operazioneCorretta = true;
                            }
                            break;

                        case "*":
                            {
                                Console.WriteLine($"{primoNumero} * {secondoNumero} = {primoNumero * secondoNumero}");
                                operazioneCorretta = true;
                            }
                            break;

                        case "/":
                            {
                                if (secondoNumero == 0)
                                {
                                    Console.WriteLine("Non è possibile eseguire una divisione per zero");
                                }
                                else
                                {
                                    Console.WriteLine($"{primoNumero} / {secondoNumero} = {primoNumero / secondoNumero}");
                                }
                                operazioneCorretta = true;
                            }
                            break;

                        default:
                            Console.WriteLine("Non hai inserito un'operazione valida");
                            break;

                    }

                }
            }
        }
    }
}
