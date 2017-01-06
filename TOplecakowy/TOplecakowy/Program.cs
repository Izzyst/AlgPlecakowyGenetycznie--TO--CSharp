using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOplecakowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Fasada odpal = new Fasada();
            odpal.start();
            odpal.zachlanie();
            Console.Read();
        }
    }
}
