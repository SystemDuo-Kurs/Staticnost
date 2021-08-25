using System;

namespace Staticnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba.Ime = "Pera";

           while(true)
           {
                Osoba a = new ();
                Osoba.Brojac++;
                Console.WriteLine($"Broj osoba je {Osoba.Brojac}");
                Console.ReadKey();

           }
        }
    }

    class Osoba
    {
        public string Ime = "asd";
        public static int Brojac;

        public static void Nesto()
        {
            
            Console.WriteLine("asd");
        }
    }

}
