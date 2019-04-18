using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> foods = listFood();

            Mum mum = new Mum();
            Dad dad = new Dad();
            Child child = new Child();

            mum.DinnerReady += dad.DadDinner;
            mum.DinnerReady += child.ChildDinner;
            mum.OnNotifyDinner(foods);
            Console.Read();
        }
        static public List<Food> listFood()
        {
            List<Food> output = new List<Food>();
            output.Add(new Food("matriciana", "pasta"));
            output.Add(new Food("carbonara", "pasta"));
            output.Add(new Food("insalata", "verdura"));
            output.Add(new Food("pollo", "carne"));
            output.Add(new Food("lattuga", "verdura"));

            return output;

        }
    }
    

    delegate void NotifyDinner(List<Food> dinner);

    class Food
    {
        public string Name { get; set; }
        public string Tipo { get; set; }

        public Food(string name, string tipo)
        {
            Name = name;
            Tipo = tipo;
        }

    }

    class Mum
    {
        public event NotifyDinner DinnerReady;
        public void OnNotifyDinner(List<Food> food)
        {
            Console.WriteLine("il pranzo è pronto");
            DinnerReady(food);
        }
    }

    class Dad
    {
        public void DadDinner(List<Food> dinner)
        {
            Console.WriteLine("Arrivooo");
        }
    }

    class Child
    {
        public void ChildDinner(List<Food> dinner)
        {
            foreach (Food item in dinner)
            {
                if (item.Tipo == "verdura")
                {
                    Console.WriteLine($"Io questo {item.Name} non lo mangio");
                }
            }
        }
    }
}
