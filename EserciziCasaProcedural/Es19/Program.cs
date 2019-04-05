using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es10_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero per creare triangolo di Tartaglia");
            int numero =Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                for (int j = numero - i; j < numero; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i - 1; j < numero; j++)
                {
                    Console.Write((j - i + 2).ToString().PadRight(3));
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}