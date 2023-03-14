using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechteck_prop
{
    public class Geometry
    {
        public Geometry()
        {
            
        }
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck();
            Console.WriteLine(r1.GetLaenge());

            //r1 .breite = 5;
            r1.SetLaenge(7);

            Rechteck r2 = Rechteck.CreateRechteck(5, 9);

            Console.WriteLine(r2.GetLaenge());
            Console.WriteLine(r2.breite);
            
        }
    }
}
