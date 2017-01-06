using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOplecakowy
{

    public interface IRozmiar// STRATEGIA
    {
        int losuj();
    }

     class RozmiarPlecaka1 : IRozmiar
    {
        public int losuj()
        {
            Random rnd = new Random();
            return rnd.Next(10, 10000);
        }
    }

    class RozmiarPlecaka2 : IRozmiar
    {
        public int losuj()
        {
            Random rnd = new Random();
            return rnd.Next(10, 100);
        }
    }
}
