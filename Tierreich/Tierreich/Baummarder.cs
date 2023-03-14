using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tierreich
{
    public class Baummarder:Tier
    {
        public Baummarder(double gewicht) : base(gewicht)
        {

        }

        protected override bool CanEat(Tier tier1)
        {
            if (tier1 is Eichhoernchen && tier1.IsAlive == true && this.IsAlive == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
