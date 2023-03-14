using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tierreich
{
    public class Uhu:Tier
    {
        public Uhu(double gewicht):base(gewicht)
        {

        }

        protected override bool CanEat(Tier tier1)  
        {
            Console.WriteLine(tier1.GetType());
            if ((tier1 is Eichhoernchen || tier1 is Baummarder) && tier1.IsAlive && this.IsAlive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Fliegen()
        {
            if(this.AktuellesGewicht -10 > this.InitialGewicht)
            {
                Console.WriteLine("altes gewicht vom Uhu ist: " + this.AktuellesGewicht);
                this.AktuellesGewicht -= 10;
            }
            else if(this.AktuellesGewicht > this.InitialGewicht)
            {
                Console.WriteLine("Aktuelles gewicht vom Uhu ist: " + this.AktuellesGewicht);
                this.AktuellesGewicht = this.InitialGewicht;
            }
            Console.WriteLine("Aktuelles gewicht vom Uhu ist: " + this.AktuellesGewicht);
            Console.WriteLine("Der Uhu fliegt ");
            
        }
   
    }
}
