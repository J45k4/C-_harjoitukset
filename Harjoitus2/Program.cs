using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Omenapuu omenapuu = new Omenapuu();
            omenapuu.Omenienmaara = 10;
            omenapuu.KasvataOmenat();
            while(true)
            {
                Omena omena = omenapuu.otaOmena();
                if (omena != null)
                {
                    omena.syo();
                } else
                {
                    break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
