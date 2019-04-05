using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int answerToAllTheQuesions = 42;

            Console.WriteLine($"As we all know, the answer to all the quesions is {answerToAllTheQuesions}");

            Console.WriteLine("Inserisci un numero e ti dirò se è divisibile per 42");
            string numeroInseritoInStringa = Console.ReadLine();
            if (int.TryParse(numeroInseritoInStringa,out int numeroInserito) == false)
            {
                Console.WriteLine("Non hai inserito un valore valido");
            }

            if (numeroInserito % answerToAllTheQuesions == 0)
            {
                Console.WriteLine("Il numero è divisibile per 42");
            }
            else
            {
                Console.WriteLine("il numero non è divisibile per 42");
            }

        }
    }
}
