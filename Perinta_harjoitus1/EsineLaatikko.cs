using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta_harjoitus1
{
    class EsineLaatikko
    {
        Random rand = new Random();
        public Esine otaEsine()
        {
            switch(rand.Next(0, 3))
            {
                case 0:
                    return new Taskulamppu();
                    break;
                case 1:
                    return new Tulitikut();
                    break;
                case 2:
                    return new Veitsi();
                    break;
            }
            return null;
        }

    }
}
