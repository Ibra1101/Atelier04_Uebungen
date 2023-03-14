using Coffeee;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaffeemaschine kaffeeMaschine1 = new Kaffeemaschine();
            Kaffeemaschine kaffeeMaschine2 = new Kaffeemaschine();
            kaffeeMaschine1.wasserAuffuellen(1.3);
            kaffeeMaschine1.bohnenAuffuellen(1.3);
            kaffeeMaschine2.wasserAuffuellen(2.5);
            kaffeeMaschine2.bohnenAuffuellen(2.6);
            KaffeeGeschaeft preis1 = new KaffeeGeschaeft(13);

            //Console.WriteLine(kaffeeMaschine2.macheKaffe(3.5, 1));
            Console.WriteLine(preis1.kaufeKaffee(5,kaffeeMaschine2));

            Vergleich.kaffeeMaschinenAngleichen(kaffeeMaschine1, kaffeeMaschine2);
            Console.WriteLine(kaffeeMaschine1.BohnenStand +" " + kaffeeMaschine1.WasserFuellStand);

            Vergleich.fuellMilch(2, null);
            
        }
    }
}
