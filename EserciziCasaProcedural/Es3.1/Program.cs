using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I numeri divisibili per 3 e 5 da 1 a 100 sono:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
