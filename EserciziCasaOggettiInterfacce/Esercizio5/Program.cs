using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adressPaolo = new Adress("Via Torino", 14, 34100, "Trieste");
            Adress adressSilvio = new Adress("Via Nazionale", 52, 33021, "Udine");
            Adress adressSara = new Adress("Via Colombo", 66, 34052, "Gorizia");

            Person paolo = new Person("Paolo", "Rossi", 182, adressPaolo, CarPaolo());
            Person silvio = new Person("Silvio", "Bianchi", 178, adressSilvio, CarSilvio());
            Person sara = new Person("Sara", "Verdi", 165, adressSara, CarSara());

            List<Person> persons = new List<Person>() { paolo, silvio, sara };

            WritePerson(persons);
           
            Console.Read();
        }




        static void WritePerson(List<Person> persons)
        {
            foreach (Person p in persons)
            {
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Surname: {p.Surname}");
                Console.WriteLine($"Height: {p.Height}");
                WriteAdress(p.HomeAdress);
                WriteCar(p.Cars);
                Console.WriteLine();
            }

        }

        static void WriteCar(List<Car> cars)
        {
            foreach (Car c in cars)
            {
                Console.WriteLine($"Car: {c.Model}, {c.Brand}, {c.Mileage} Km");
            }
        }
        static void WriteAdress(Adress adress)
        {
            Console.WriteLine($"Adress: {adress.Street} {adress.Number}, {adress.ZipCode} {adress.City}");
        }

        static List<Car> CarPaolo()
        {
            return new List<Car>()
            {
                new Car("Serie 3", "BMW", 100000),
                new Car("500", "Fiat", 50000)
            };
        }

        static List<Car> CarSilvio()
        {
            return new List<Car>()
            {
                new Car("C3", "Citroen", 25000)
            };
        }

        static List<Car> CarSara()
        {
            return new List<Car>()
            {
                new Car("Classe A", "Mercedes", 10000),
                new Car("306", "Peugeot", 200000),
            };
        }

        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Height { get; set; }
            public Adress HomeAdress { get; set; }
            public List<Car> Cars { get; set; }
            public Person(string name, string surname, int height, Adress homeadress, List<Car> cars)
            {
                Name = name;
                Surname = surname;
                Height = height;
                HomeAdress = homeadress;
                Cars = cars;
            }
        }
        class Adress
        {
            public string Street { get; set; }
            public int Number { get; set; }
            public int ZipCode { get; set; }
            public string City { get; set; }
            public Adress(string street, int number, int zipCode, string city)
            {
                Street = street;
                Number = number;
                ZipCode = zipCode;
                City = city;
            }
        }
        class Car
        {
            public string Model { get; set; }
            public string Brand { get; set; }
            public int Mileage { get; set; }
            public Car(string model, string brand, int mileage)
            {
                Model = model;
                Brand = brand;
                Mileage = mileage;
            }
        }
    }
}
