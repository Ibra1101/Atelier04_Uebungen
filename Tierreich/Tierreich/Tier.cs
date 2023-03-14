using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tierreich
{
    public abstract class Tier
    {
        public double AktuellesGewicht { protected set; get; }
        public double InitialGewicht { private set; get; }
        public bool IsAlive { private set; get; }

        public Tier(double gewicht)
        {
            this.IsAlive = true;
            AktuellesGewicht = gewicht;
            InitialGewicht = gewicht;
        }

        protected abstract bool CanEat(Tier tier1);
        public void WirdGetötet()
        {
            IsAlive = false;
        }

        public void Eat(Tier tier1)
        {
            if (this.CanEat(tier1))
            {
                this.AktuellesGewicht += tier1.AktuellesGewicht;
                tier1.WirdGetötet();
                tier1.Verdauen();
            }
            else
            {
                Console.WriteLine("Tier kann nicht gefressen werden.");
            }
        } 

        public void Verdauen()
        {
            if(AktuellesGewicht > InitialGewicht)
            {
                double zustaetzlicherGewicht;

                zustaetzlicherGewicht = (AktuellesGewicht - InitialGewicht) * 0.05;

                AktuellesGewicht = InitialGewicht + zustaetzlicherGewicht;
            }
        }


    }
}
