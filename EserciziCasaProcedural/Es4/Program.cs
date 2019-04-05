using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci prima parola");
            string string1 = Console.ReadLine();

            Console.WriteLine("Inserisci seconda parola");
            string string2 = Console.ReadLine();

            Console.WriteLine($"{string1}{string2}  {string2}{string1}");

            Console.ReadLine();
        }
    }
}
