using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeee
{
    public class Kaffeemaschine
    {
        static double maxWasser = 2.5;
        static double maxKaffee = 2.5;
        double wasser;
        public double Wasser
        {
            get { return wasser; }
            private set { wasser = value; }
        }
        double bohnenStand;
        public double BohnenStand
        {
            get { return bohnenStand; }
            private set { bohnenStand = value; }
        }
        double wasserFuellStand;
        public double WasserFuellStand
        {
            get { return wasserFuellStand; } 
            private set { wasserFuellStand= value; }
        
        }
        double kaffeeFuellStand;
        public double Kaffefuellstand
        {
            get { return kaffeeFuellStand; }
            private set { kaffeeFuellStand= value;}
        }

        public Kaffeemaschine()
        {
            wasser = 0;
            BohnenStand = 0;
            kaffeeFuellStand = 0;
        }

        public double wasserAuffuellen(double menge)
        {
            if(wasserFuellStand + menge < maxWasser)
            {
                wasserFuellStand += menge;
                Console.WriteLine("Aktuelle WasserStand ist " + wasserFuellStand);
                return menge;
                
            }
            else
            {
                WasserFuellStand = maxWasser;
                return maxWasser;
            }
            
        }
        public double bohnenAuffuellen(double menge)
        {
            if( bohnenStand + menge < maxKaffee)
            {
                bohnenStand += menge;
                Console.WriteLine("Aktuelle Bohnen ist " + bohnenStand);
                return menge;
            }
            else
            {
                bohnenStand = maxKaffee;
                Console.WriteLine("Aktuelle Bohnenstand ist " + maxKaffee);
                return maxKaffee;

            }
            
        }
        public bool macheKaffe(double menge, double verhaeltnisWasserBohnen)
        {
            double kaffemenge;
            double wassermenge;
            if (verhaeltnisWasserBohnen == 1 )
            {
                wassermenge = menge / 2;

                kaffemenge = wassermenge;

                if( BohnenStand -kaffemenge >=0 && wasserFuellStand - wassermenge >=0)
                { 
                    wasserFuellStand -= wassermenge;
                    bohnenStand -= kaffemenge;
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);

                    return true;
                }
                else
                {
                    Console.WriteLine("Ned genügend wasser oder kaffe!");
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);
                    return false;
                }
            }
            if(verhaeltnisWasserBohnen == 2)
            {
                wassermenge = (menge / 3) * 2;
                kaffemenge = menge/ 3;

                if (BohnenStand - kaffemenge >= 0 && wasserFuellStand - wassermenge >= 0)
                {
                    wasserFuellStand -= wassermenge;
                    bohnenStand -= kaffemenge;
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);
                    return true;
                }
                else
                {
                    Console.WriteLine("Ned genügend wasser oder kaffee!");
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);
                    return false;
                }
            }
            if (verhaeltnisWasserBohnen == 3)
            {
                wassermenge = (menge / 3);
                kaffemenge = wassermenge * 2;

                if (BohnenStand - kaffemenge >= 0 && wasserFuellStand - wassermenge >= 0)
                {
                    wasserFuellStand -= wassermenge;
                    bohnenStand -= kaffemenge;
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);

                    return true;

                }
                else
                {
                    Console.WriteLine("Ned genügend wasser oder kaffee!");
                    Console.WriteLine("Aktuelle KaffeStand ist " + bohnenStand);
                    Console.WriteLine("Aktuelle Wasserstand ist " + wasserFuellStand);
                    return false;
                }

            }
            return false;
        }

        
    }
}
