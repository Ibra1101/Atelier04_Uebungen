using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class WertpapierDepot : Bankkonto
    {
        public WertpapierDepot(string name, double betrag ) : base(name,betrag)
        {
            
        }
        public override void MonatsEndeTransaction()
        {
            if(Guthaben > 500)
            {
                double betrag = Guthaben * 0.05;
                NeueEinzahlung(betrag, DateTime.Now, " Zinsen");
            }
        }

    }
}
