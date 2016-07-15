using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta_harjoitus1
{
    class Pelaaja
    {
        List<Esine> reppu = new List<Esine>();
        Random rand = new Random();
        public List<Esine> Reppu {
            get
            {
                return reppu;
            }
        }

        public void LisaaEsineReppuun(Esine esine)
        {
            reppu.Add(esine);
        }

        public Esine otaEsine()
        {
            if (reppu.Count > 0)
            {
                int i = rand.Next(0, reppu.Count);
                Esine esine = reppu[i];
                reppu.RemoveAt(i);
                return esine;
            } else
            {
                return null;
            }
        }
    }
}
