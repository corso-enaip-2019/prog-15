using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es13
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    somma += i;
                }
            }
            Console.WriteLine($"La somma di tutti i numeri divisibili per 3 o 5 inferirori a 1000 è: {somma}");
            Console.Read();
        }
    }
}
