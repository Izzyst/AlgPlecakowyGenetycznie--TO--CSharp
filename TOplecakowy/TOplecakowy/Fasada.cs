using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TOplecakowy
{
    class Fasada
    {
        static List<Przedmiot> przedmioty = generuj().ToList();

        public static System.Collections.Generic.IEnumerable<Przedmiot> generuj()
        {
            Random rnd = new Random();
            int l = rnd.Next(10, 10000);
            for (int i = 0; i < l; i++)
            {
                yield return new Przedmiot() { Id = i, Rozmiar = rnd.Next(0, 100), Wartosc = (float)rnd.Next(100, 100000) / 100 };
            }
        }

        public static void wypisz_przedmioty()
        {
            foreach (var i in przedmioty)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("ilosc przedmiotów: " + przedmioty.Count + " łączna wartość: " + przedmioty.Sum((a) => a.Wartosc) + " łączny rozmiar: " + przedmioty.Sum((a) => a.Rozmiar));

        }

        public  void zachlanie()
        {
            Plecak plecak = Plecak.Instance();// wywolanie instancji tworzonej przez singleton
            var kopia = przedmioty;
            Console.WriteLine("\rozwiazanie algorytmem zachlannym:\r");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            kopia.Sort();
            for (int i = 0; i < kopia.Count; i++)
            {
                plecak.addPrzedmiot(kopia[i]);
            }
            stopwatch.Stop();
            Console.WriteLine(string.Join(Environment.NewLine, plecak.Zawartosc.Select(s => "Indyfiktor " + s.Id + " Rozmir " + s.Rozmiar + " Wrtosc " + s.Wartosc)));
            //  Console.WriteLine( rozwiazanie.Rozmiar_zawartosci);

            Console.WriteLine("czas: {0}", stopwatch.Elapsed);
        }

        public void start()
        {
            IRozmiar size = null;
            size = new RozmiarPlecaka2();
            Plecak.Rozmiar_plecaka = size.losuj();
        }

    }
}
