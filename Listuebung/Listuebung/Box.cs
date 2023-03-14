using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listuebung
{
    public class Box : IComparable<Box>
    {
        public int Laenge;
        public int Breite;
        public int Hoehe;

        public Box(int laenge, int breite, int hoehe)
        {
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
        }

        public int CompareTo(Box? b)
        {
            if (this.Hoehe.CompareTo(b.Hoehe) != 0)
            {
                return this.Hoehe.CompareTo(b.Hoehe);
            }
            else if (this.Laenge.CompareTo(b.Laenge) != 0)
            {
                return this.Laenge.CompareTo(b.Laenge);
            }
            else if (this.Breite.CompareTo(b.Breite) != 0)
            {
                return this.Breite.CompareTo(b.Breite);
            }
            else
            {
                return 0;
            }
                
                  
        }
    }
}
