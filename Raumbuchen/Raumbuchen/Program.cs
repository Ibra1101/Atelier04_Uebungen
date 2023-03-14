using System;

namespace Raumbuchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company Eins = new Company("Google", 130,"Unicersum",150);
            Company zwei = new Company("Google", 125,"Unicersum",150);
            Company drei = new Company("Google", 27,"Unicersum",150);
            Console.WriteLine(Eins.Frei());

            Eins.FuegeEinenRaumHinzu(20);

            Eins.SucheRaum(30);
            Eins.SucheRaum(18);

            Console.WriteLine(Eins.Frei());
        }
    }
}