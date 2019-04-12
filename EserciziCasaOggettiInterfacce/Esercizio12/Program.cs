using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio12
{
    class Program
    {
        static void Main(string[] args)
        {
            var mario = new Bambino("Mario");
            var giovanni = new Bambino("Giovanni");
            var giulia = new Bambino("Giulia");
            var chiara = new Bambino("Chiara");

            mario.AggiungiAmico(chiara);
            mario.AggiungiAmico(giovanni);

            chiara.AggiungiAmico(giovanni);
            chiara.AggiungiAmico(giulia);

            giulia.AggiungiAmico(giovanni);

            //Test per controllare che non ci siano copie dello stesso amico nella lista
            //Giulia è già stata aggiunta agli amici da Chiara
            giulia.AggiungiAmico(chiara);

            Bambino.StampaListaAmiciBambino(mario);
            Bambino.StampaListaAmiciBambino(chiara);
            Bambino.StampaListaAmiciBambino(giovanni);
            Bambino.StampaListaAmiciBambino(giulia);
            Console.ReadLine();
        }
    }
    class Bambino
    {
        public Bambino(string nome)
        {
            Nome = nome;
            Amici = new List<Bambino>();
        }
        public string Nome { get; set; }
        public List<Bambino> Amici { get; }

        public void AggiungiAmico(Bambino bambino)
        {

            if (!bambino.Amici.Contains(this))
            {
                Amici.Add(bambino);
                bambino.Amici.Add(this);
            }


        }

        public static void StampaListaAmiciBambino(Bambino bambino)
        {
            Console.WriteLine($"lista di amidi di {bambino.Nome}:");
            foreach (var b in bambino.Amici)
            {
                Console.WriteLine($"{b.Nome}");
            }
            Console.WriteLine();
        }
    }
}
