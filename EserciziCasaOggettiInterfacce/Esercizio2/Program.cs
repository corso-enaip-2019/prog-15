using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stanza cucina = new Stanza("cucina", CreaMuri());

            Console.WriteLine($"La superficie totale della {cucina.Nome} è: {cucina.SuperficieTotale()}");

            Console.Read();
        }
        static List<Muro> CreaMuri()
        {
            return new List<Muro>
            {
                new Muro(700,330),
                new Muro(400,330),
                new Muro(800,330),
                new Muro(500,330),
            };
        }
    }
    class Muro
    {
        public int Lunghezza { get; set; }
        public int Altezza { get; set; }

        public Muro(int lunghezza, int altezza)
        {
            Lunghezza = lunghezza;
            Altezza = altezza;
        }

        public double SuperficeMuro()
        {
            return Lunghezza * Altezza;
        }
    }
    class Stanza
    {
        public string Nome { get; set; }
        public List<Muro> Muri { get; set; }
        private int _superficieTotale = 0;

        public int SuperficieTotale()
        {
            foreach (Muro m in Muri)
            {
                _superficieTotale += m.Lunghezza;
            }
            return _superficieTotale;
        }

        public Stanza(string nome, List<Muro> muri)
        {
            Nome = nome;
            Muri = muri;
        }

    }
}