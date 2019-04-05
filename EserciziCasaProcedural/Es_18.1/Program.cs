using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[10];
            int numMax = 0;
            int numMin = 0;
            int totale = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"inserisci il nnumero {i + 1}-esimo");
                numeri[i] = Convert.ToInt32(Console.ReadLine());
            }
            numMin = numeri[1];
            for (int i = 0; i < 10; i++)
            {

                totale = totale + numeri[i];

                if (numMax < numeri[i])
                {
                    numMax = numeri[i];
                }
            }
            for (int i = 0; i < 10; i++)
            {

                if (numMin > numeri[i])
                {

                    numMin = numeri[i];
                }

            }
            Console.WriteLine($"Il numero massimo è: {numMax}\r\nIl numero minimo è: {numMin}\r\nLa media è: {totale / 10}");
            Console.ReadLine();
        }
    }
}
