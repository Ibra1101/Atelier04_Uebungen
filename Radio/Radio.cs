using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public class Radio
    {
        public bool Eingeschaltet = false;
        public int Lautstaerke { get; set; }
        public double Frequenz { get; set; }

        
        public Radio() { }

        public Radio(Boolean istAn, int lautstaerke,double frequenz)
        {

        }

        public void Leiser(int menge)
        {
            if(Eingeschaltet == true)
            {
                if(Lautstaerke - menge < 0)
                {
                    Lautstaerke = 0;
                }
                else
                {
                    Lautstaerke -= menge;
                }
            }
            else
            {
                Console.WriteLine("Radio ist aus");
            }
            Console.WriteLine("Lautstärke betragt:" + Lautstaerke);
        }
        public void Lauter(int menge)
        {
            if (Eingeschaltet == true)
            {
                if (Lautstaerke + menge > 10)
                {
                    Lautstaerke = 10;
                }
                else
                {
                    Lautstaerke += menge;
                }
            }
            else
            {
                Console.WriteLine("Radio ist aus");
            }
            Console.WriteLine("Lautstärke betragt:" + Lautstaerke);
        }
        public void An()
        {
            Eingeschaltet = true;
            Console.WriteLine("Radio ist ein ");
        }
        public void Aus()
        {
            Eingeschaltet = false;
            Console.WriteLine("Radio is aus");
        }

        
        public override string ToString()
        {
           return("Radio ist: " + Eingeschaltet + " Lautstärke: " + Lautstaerke + " Frequenz ist: "+ Frequenz );
           
        }

        public void Frequenzwaehlen(double frequenz)
        {
            if (frequenz > 110 || frequenz < 88)
            {
                Frequenz = 99.9;
            }
            else
            {
                Frequenz = frequenz;
            }
        }
    }
}
