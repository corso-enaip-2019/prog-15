using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeriFibonacci = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                numeriFibonacci[i] = numeriFibonacci[i] + numeriFibonacci[i - 1];
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.Write($"{numeriFibonacci[i]}");
            }

            Console.ReadLine();
        }
    }
}
