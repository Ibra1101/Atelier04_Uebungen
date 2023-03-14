using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeee
{
    public class KaffeeGeschaeft
    {
        double _preisProKg;

        public double PreisProKg
        {
            get { return _preisProKg; }

            set 
            {
                if (value > 5 && value < 30)
                { 
                    _preisProKg = value;
                }
                else
                {
                    Console.WriteLine("Preis muss über 5 und unter 30 sein ");
                }

            }
        }

        public KaffeeGeschaeft(double preisProKg)
        {
            _preisProKg = preisProKg;
        }

        public double kaufeKaffee(double menge, Kaffeemaschine kaffeemaschine)
        {
            double neueMenge;
            neueMenge = kaffeemaschine.bohnenAuffuellen(menge);

            return neueMenge * PreisProKg;
        }

    }

}
