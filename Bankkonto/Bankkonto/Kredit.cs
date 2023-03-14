using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class Kredit : Bankkonto
    {
        public Kredit(string name, double betrag, double min) :base (name, -betrag, min)

        { 
         
        }
        public override void MonatsEndeTransaction()
        {
            if (Guthaben <0)
            {
                double betrag = -Guthaben * 0.07;
                NeueAusZahlung(betrag, DateTime.Now, " Zinsen fuern Kredit");
            }
        }
    }
}
