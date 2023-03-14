using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class KreditKarte : Bankkonto
    {
        private readonly double _monatsEinzahlung = 0;
        public KreditKarte(string name, double betrag, double monathsBetrag) :base (name, betrag) => _monatsEinzahlung = monathsBetrag;
        public override void MonatsEndeTransaction()
        {
            if (_monatsEinzahlung != 0)
            {
                NeueEinzahlung(_monatsEinzahlung, DateTime.Now, "Monatliche Einzahlung");
            }
        } 

    }
}
