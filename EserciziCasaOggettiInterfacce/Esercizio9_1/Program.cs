using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStatisticaProvaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci dei valori e ti dirò la media aritmetica e lo scarto quadratico medio");

            CalcoloStatistico calcolo = new CalcoloStatistico();

            calcolo.valori = calcolo.InserimentoValori();

            calcolo.media = calcolo.CalcolaMedia();
            Console.WriteLine($"La media dei valori inseriti è uguale a: {calcolo.media}");

            calcolo.scartoQuadraticoMedio = calcolo.CalcolaScartoQuadraticoMedio();
            Console.WriteLine($"Lo scarto quadratico medio è: {calcolo.scartoQuadraticoMedio}");

            Console.Read();
        }



        class CalcoloStatistico
        {
            public List<double> valori;

            public double media;

            public double scartoQuadraticoMedio;

            public double CalcolaMedia()
            {
                double totale = 0;
                for (int i = 0; i < valori.Count; i++)
                {
                    totale += valori[i];
                }
                double media = totale / valori.Count;
                return media;
            }

            public List<double> InserimentoValori()
            {
                string inserimento = "";

                while (inserimento != "f")
                {
                    Console.WriteLine("\r\nInserisci un valore o digita 'f' per finire");

                    inserimento = Console.ReadLine();
                    if (inserimento == "f")
                    {
                        break;
                    }
                    if (double.TryParse(inserimento, out double valore) == false)
                    {
                        Console.WriteLine("Non hai inserito un valore valido\r\n");
                    }
                    else if (double.TryParse(inserimento, out valore))
                    {
                        valori.Add(valore);
                    }
                }
                return valori;
            }

            public double CalcolaSommatoria()
            {
                double sommatoria = 0;
                for (int i = 0; i < valori.Count; i++)
                {
                    sommatoria += Math.Pow(valori[i] - media, 2);
                }
                return sommatoria;
            }

            public double CalcolaScartoQuadraticoMedio()
            {
                return scartoQuadraticoMedio = Math.Sqrt(CalcolaSommatoria() / valori.Count);

            }

            public CalcoloStatistico()
            {
                valori = new List<double>();
            }
        }
    }
}