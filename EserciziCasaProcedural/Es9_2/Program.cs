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
            for (int i = 50; i <= 60; i++)
            {
                Console.Write(i.ToString().PadRight(5));
            }
            Console.WriteLine();

            for (int i = 51; i <= 61; i++)
            {
                Console.Write((i - 1).ToString().PadRight(5));
                for (int j = 51; j <= 61; j++)
                {
                    Console.Write(((i - 1) * (j - 1)).ToString().PadRight(5));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
