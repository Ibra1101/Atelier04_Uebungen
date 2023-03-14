using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeee
{
    public static class Vergleich
    {
        public static void kaffeeMaschinenAngleichen(Kaffeemaschine kaffeemaschine1, Kaffeemaschine kaffeemaschine2)
        {
            if(kaffeemaschine1.WasserFuellStand > kaffeemaschine2.WasserFuellStand)
            {
                kaffeemaschine2.wasserAuffuellen(kaffeemaschine1.WasserFuellStand - kaffeemaschine2.WasserFuellStand);
            }
            if (kaffeemaschine2.BohnenStand > kaffeemaschine1.BohnenStand)
            {
                kaffeemaschine1.bohnenAuffuellen(kaffeemaschine2.BohnenStand - kaffeemaschine1.BohnenStand);
                
            }
            if(kaffeemaschine1.BohnenStand > kaffeemaschine2.BohnenStand)
            {
                kaffeemaschine2.bohnenAuffuellen(kaffeemaschine1.BohnenStand - kaffeemaschine2.BohnenStand);
            }
            if (kaffeemaschine2.WasserFuellStand > kaffeemaschine1.WasserFuellStand)
            {
                kaffeemaschine1.wasserAuffuellen(kaffeemaschine2.WasserFuellStand - kaffeemaschine1.WasserFuellStand);
            }
           
        }

        public static void fuellMilch(double menge,Kaffeemaschine kaffeemaschine)
        {
            if (kaffeemaschine == null)
            {
                Kaffeemaschine neueKaffemaschine = new Kaffeemaschine();
                neueKaffemaschine.wasserAuffuellen(menge);
            }
            else if (kaffeemaschine.WasserFuellStand < menge)
            {
                kaffeemaschine.wasserAuffuellen(menge);
            }
            
        }
    }

    
}
