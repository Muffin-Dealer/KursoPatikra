using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursoPatikra1
{
    class Program
    {
        static void Main(string[] args)
        {
            PirmaUzduotis();
            AntraUzduotis();
            TreciaUzduotis();
            KetvirtaUzduotis();
            PenktaUzduotis();

        }
           
        public static void PirmaUzduotis()
        {
            // 1 Aprašykit kintamąjį x, realiųjų skaičių tipu.
            double x;
        }
        public static void AntraUzduotis()
        {
            // 2 Parašykite funkciją, kuri konvertuotų žodinį kintamąjį “žodis” į sveikąjį skaičių ir priskirtų jį sveikajam kintamajam a.
            string zodis = "zodis";
            int a = 0;
            foreach (var item in zodis.ToCharArray())
            {
                a += Convert.ToInt32(item);
            }
            //int b = Convert.ToInt32(zodis);
            //int c = int.Parse(zodis);
            Console.WriteLine(a);
        }
        public static void TreciaUzduotis()
        {
            // 3 Parašykite ciklą for kuris į ekraną išvetų visus skaičius nuo 0 iki 10.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void KetvirtaUzduotis()
        {
            // 4 Parašykite kodą kuris iš 3 skaičių rastų didžiausią.
            Console.WriteLine("Iveskite 3 skaicius :");
            Console.WriteLine("Iveskite pirma skaiciu :");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu :");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu :");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("skaicius {0} yra didziausias", sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine("skaicius {0} yra didziausias", sk2);
            }
            else if (sk3 > sk2 && sk3 > sk1)
            {
                Console.WriteLine("skaicius {0} yra didziausias", sk3);
            }
            else
                Console.WriteLine("Visi lygus");
        }
        public static void PenktaUzduotis()
        {
            List<Pirkiniai> prekes = new List<Pirkiniai>();
            prekes.Add(new Pirkiniai("gadf1", "Guma", 2.5));
            prekes.Add(new Pirkiniai("nvbc84", "Medis", 70));
            prekes.Add(new Pirkiniai("ga4g8e", "Koja", 50.5));
            prekes.Add(new Pirkiniai("87wrt2", "Dzinsai", 5.05));
            prekes.Add(new Pirkiniai("45g4sd", "Stalas", 79.05));
            prekes.Add(new Pirkiniai("gads41", "Tusinis", 2));
            prekes.Add(new Pirkiniai("775f1", "Tortas", 8.79));
            List<Pirkiniai> pirkiniai = new List<Pirkiniai>();
            double suma = 0;
            Console.WriteLine("I pirkiniu sarasa ideta");
            foreach (var item in prekes)
            {
                if (item.Price < 51)
                {
                    pirkiniai.Add(item);
                    suma += item.Price;
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine("Moketi uz viska : " + suma);

        }

    }
    class Pirkiniai
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Pirkiniai(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
}
