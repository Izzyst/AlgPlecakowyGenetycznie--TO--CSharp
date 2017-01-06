using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOplecakowy
{
    class Przedmiot : IComparable<Przedmiot>
    {
        public int Id { get; set; }
        public int Rozmiar { get; set; }
        public float Wartosc { get; set; }

        public override string ToString()
        {
            return "indyfikator: " + this.Id + " rozmiar: " + this.Rozmiar + " wartosc: " + this.Wartosc;
        }
        public int CompareTo(Przedmiot o)
        {
            if (this.Wartosc > o.Wartosc)
                return -1;
            if (this.Wartosc == o.Wartosc)
            {
                if (this.Rozmiar < o.Rozmiar)
                {
                    return -1;
                }
                else
                {
                    if (this.Rozmiar == o.Rozmiar)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            return 1;
        }
    }
}
