using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> luvut = new List<int>();
            Tehtava1(luvut);
            Tehtava1(luvut);
            for (int i = 0; i < luvut.Count; i++)
            {
                Console.WriteLine(luvut[i]);
            }
            int luku = 5;
            Tehtava2(luku);
            Console.WriteLine(luku);
            Console.ReadKey();
        }

        static public void Tehtava1(List<int> luvut)
        {
            Random rand = new Random();
            luvut.Add(rand.Next(1, 10));
        }

        static public void Tehtava2(int luku)
        {
            luku *= 2;
        }
    }
}
