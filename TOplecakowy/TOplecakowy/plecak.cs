using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOplecakowy
{
    class Plecak
    {
        public static int Rozmiar_plecaka { get; set; }
        public int Rozmiar_zawartosci { get; set; }
        public float Wartosc { get; set; }
        private List<Przedmiot> zawartosc = new List<Przedmiot>();
        private static Plecak instance;

        private Plecak()
        {

        }

        public static Plecak Instance()// SINGLETON => tworzenie nowej instancji w przypadku gdy nie została utworzona
        {
            if (instance == null)
                instance = new Plecak();
            return instance;
        }

        public List<Przedmiot> Zawartosc
        {
            get { return zawartosc; }
            private set { zawartosc = value; }
        }
        public bool addPrzedmiot(Przedmiot item)
        {
            if (Rozmiar_plecaka >= Rozmiar_zawartosci + item.Rozmiar)
            {
                zawartosc.Add(item);
                return true;
            }
            return false;
        }
    }
}
