using System;
using System.Xml.Linq;

namespace Bankkonto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankkonto b1 = new Bankkonto();
            Bankkonto b2 = new Bankkonto();
            Bankkonto b3 = new Bankkonto();
            Bankkonto b4 = new Bankkonto("Ilay", 1000);

            //b4.Abheben(30);
            //b4.UeberzeihungsRahmenErhoehen();
            //Console.WriteLine(b4.ToString());


            var wertPapier = new WertpapierDepot("GutscheinKarte", 100);
            wertPapier.NeueEinzahlung(720, DateTime.Now, "GeldAnlegen");
            wertPapier.NeueEinzahlung(1250, DateTime.Now, "GeldAnlegen");
            wertPapier.NeueAusZahlung(1000, DateTime.Now, "Wertpaper Auszahlen");

            wertPapier.MonatsEndeTransaction();
            wertPapier.NeueEinzahlung(100000, DateTime.Now, "Zustaetzliche Einzahlung");
            Console.WriteLine(wertPapier.GetAccountHistory());

            Console.WriteLine(b1.ToString());
            b1.NeueEinzahlung(500, DateTime.Now, "Sparen");
            b1.NeueEinzahlung(1000, DateTime.Now, "Auto");
            b1.NeueAusZahlung(800, DateTime.Now, "reparaturen");
            b3.NeueEinzahlung(-50, DateTime.Now, "Test");
            Console.WriteLine(b1.ToString());

            Console.WriteLine(b1.GetAccountHistory());



            /*
            b1.Einzahlen(51.99);
            b2.Einzahlen(12.99);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b3.ToString());

            b1.Abheben(100);
            b2.Abheben(20);
*/

            var kreditkarte = new KreditKarte("GutscheinKarte", 100, 50);
            kreditkarte.NeueAusZahlung(20, DateTime.Now, "Starbugs");
            kreditkarte.NeueAusZahlung(50, DateTime.Now, "Schmuckkauf");

            kreditkarte.MonatsEndeTransaction();
            kreditkarte.NeueEinzahlung(27.50, DateTime.Now, "Zustaetzliche Einzahlung");
            Console.WriteLine(kreditkarte.GetAccountHistory());



            var kredit = new Kredit("kredit", 0, 5000);
            kredit.NeueAusZahlung(1000,DateTime.Now, "Motorad");
            kredit.NeueAusZahlung(500, DateTime.Now, "Helm");
            kredit.NeueEinzahlung(100, DateTime.Now, "Abzahlen");
            kredit.MonatsEndeTransaction();
            Console.WriteLine(kredit.GetAccountHistory());

        }
    }
}