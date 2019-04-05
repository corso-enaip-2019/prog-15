using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppCicliFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("     ");
            for (int i = 5; i <= 10; i++)
            {
                Console.Write(i.ToString().PadRight(5));
            }
            Console.WriteLine();

            for (int i = 6; i <= 11; i++)
            {
                Console.Write((i - 1).ToString().PadRight(5));
                for (int j = 6; j <= 11; j++)
                {
                    Console.Write(((i - 1) * (j - 1)).ToString().PadRight(5));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
