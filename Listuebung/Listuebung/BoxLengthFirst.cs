using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listuebung
{
    public class BoxLengthFirst : Comparer<Box>
    {
        public override int Compare(Box x, Box y)
        {
            if (x.Laenge.CompareTo(y.Laenge) != 0)
            {
                return x.Laenge.CompareTo(y.Laenge);
            }
            else if (x.Hoehe.CompareTo(y.Hoehe) != 0)
            {
                return x.Hoehe.CompareTo(y.Hoehe);
            }
            else if (x.Breite.CompareTo(y.Breite) != 0)
            {
                return x.Breite.CompareTo(y.Breite);
            }
            else
            {
                return 0;
            }
        }
    }
}
