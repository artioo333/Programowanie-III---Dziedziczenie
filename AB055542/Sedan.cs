using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace AB055542
{
    public class Sedan : IPojazd
    { 
        public Silnik_1 Silnik_1 { get; set; }
        public void Jedz()
        {
            throw new NotImplementedException();
        }

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
            Silnik_1.Dzialaj();
                Console.WriteLine(" ");
            }
        }

        public Sedan(Silnik_1 silnik)
        {
            Silnik_1 = silnik;
        }
    }
}
