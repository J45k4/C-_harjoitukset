using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    class Omena
    {
        private OmenanTila tila;

        public Omena(OmenanTila t)
        {
            tila = t;
            
        }

        public void syo()
        {
            switch(tila)
            {
                case OmenanTila.KYPSA:
                    Console.WriteLine("Omena on syöty");
                    break;
                case OmenanTila.RAAKA:
                    Console.WriteLine("Omena on vielä raaka");
                    break;
                case OmenanTila.MADANTYNYT:
                    Console.WriteLine("Omena on mädäntynyt heitä se pois");
                    break;
            }
        }
    }
}
