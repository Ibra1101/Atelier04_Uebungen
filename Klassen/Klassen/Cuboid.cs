using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Cuboid : Rechteck
    {
        private int hoehe {get;set;}

        public Cuboid(int laenge, int breite, int hoehe) : base(laenge,breite)
        {
            this.hoehe = hoehe; 
        }

        public Cuboid() :this (1,1,1)
        {
        
        }

        public int GetArea()
        {
            return 2 * base.GetArea() + 2 * GetLaenge() * hoehe + 2 * breite * hoehe;
        }

    }
}
