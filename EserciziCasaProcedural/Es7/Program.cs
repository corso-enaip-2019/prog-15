using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 19; i >= -4; i--)
            {
                Console.Write(i.ToString().PadRight(3));
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = -4; i <= 19; i=i+3)
            {
                Console.Write(i.ToString().PadRight(3));
            }
            Console.ReadLine();
        }

        
    }
}
