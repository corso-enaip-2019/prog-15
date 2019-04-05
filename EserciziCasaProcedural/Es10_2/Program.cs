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

            for (int i = 10; i >0; i--)
            {
                for (int j = 10-i; j < 10; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i-1; j < 10; j++)
                {
                    Console.Write((j-i+2).ToString().PadRight(2));
                }
                Console.WriteLine();
            }
            
            Console.Read();
        }
    }
}
