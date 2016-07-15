using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            EsineLaatikko laatikko = new EsineLaatikko();
            Pelaaja pelaaja = new Pelaaja();
            pelaaja.LisaaEsineReppuun(laatikko.otaEsine());
            pelaaja.otaEsine().Toiminto();
            Console.ReadKey();
        }
    }
}
