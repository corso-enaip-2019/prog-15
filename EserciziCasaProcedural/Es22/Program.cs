using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es22
{
    class Program
    {
        static void Main(string[] args)
        {
            int esponente = 1;
            double num = 1;
            double numMax = 0;
            while (num > numMax)
            {
                numMax = num;
                num = num * Math.Pow(10, esponente);
               
                    Console.WriteLine(num);
                esponente++;
                
            }
            Console.WriteLine(numMax);
            Console.Read();
        }
    }
}
