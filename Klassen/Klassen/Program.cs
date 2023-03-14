using Klassen;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck();
            Console.WriteLine(r1.GetLaenge());

            //r1 .breite = 5;
            r1.SetLaenge(7);

            Rechteck r2 = Rechteck.CreateRechteck(5, 9);

            Console.WriteLine(r2.GetLaenge());
            Console.WriteLine(r2.breite);
            Console.WriteLine("Fläche Rechteck"+ r2.GetArea());

            Cuboid c1 = new Cuboid(5, 8, 3);

            Console.WriteLine(c1.GetLaenge());
            Console.WriteLine("Fläche Cuboid" + c1.GetArea());


        }
    }
}