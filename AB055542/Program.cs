using Dziedziczenie;
using System;

namespace AB055542
{
    public class Program { 
        static void Main(string[] args)
        {
            Sedan Volvo = new Sedan(new Silnik_1(100, 21));

            Volvo.Jedz(100);
            Console.ReadKey();

    
        }
    }
}
