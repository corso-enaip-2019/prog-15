using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero ti dirò il doppio e il triplo");
            double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Il doppio del numero è: {numero * 2}\r\nIl triplo del numero è:{numero * 3}");

            Console.ReadLine();
        }
    }
}
