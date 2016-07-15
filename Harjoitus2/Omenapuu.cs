using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    class Omenapuu
    {
        Stack<Omena> omenat = new Stack<Omena>();

        public int Omenienmaara { get; set; }

        public void KasvataOmenat()
        {
            Random rand = new Random();
            for (int i = 0; i < Omenienmaara; i++)
            {
                omenat.Push(new Omena((OmenanTila)rand.Next(1, 4)));
            }
        }
        
        public Omena otaOmena()
        {
            if (omenat.Count > 0)
            {
                return omenat.Pop();
            } else
            {
                return null;
            }
            
        }
    }
}
