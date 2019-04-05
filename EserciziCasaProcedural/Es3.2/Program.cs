using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i + " fizz");
                    continue;
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i + " buzz");
                    continue;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " fizzbuzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    continue;
                }
                
            }
            Console.ReadLine();
        }
    }
}
