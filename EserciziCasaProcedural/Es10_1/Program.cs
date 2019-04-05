using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dammi un numero e stamperò il triangolo numerico");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                for (int j = i; j <= numero; j++)
                {
                    Console.Write(j-i+1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
