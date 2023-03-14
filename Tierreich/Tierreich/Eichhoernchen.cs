using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tierreich
{
    public class Eichhoernchen : Tier
    {

        public Eichhoernchen(double gewicht) : base(gewicht) 
        {

        }

        protected override bool CanEat(Tier tier1)
        {
            return false;
        }
    }
}
