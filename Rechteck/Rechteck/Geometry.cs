using rechteck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechteck
{
    internal class Geometry
    {
        static void Main(string[] args)
        {
            
            Rechteck r1 = new Rechteck();
            Rechteck r2 = new Rechteck(3, 4);

            Console.WriteLine(r1.GetLaenge());
            //r1.breite = 10;
            Console.WriteLine(r1.Getbreite());
            Console.WriteLine(r2.GetLaenge());
            Console.WriteLine(r2.Getbreite());
            r1.SetLaenge(10);

            Console.WriteLine(r1.Umfang());
            Console.WriteLine(r2.Umfang());
        }
    }
}
