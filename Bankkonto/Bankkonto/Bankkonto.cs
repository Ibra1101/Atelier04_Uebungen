using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class Bankkonto
    {
        private string Name { get; set; }
        private int KontoNummer { get; set; }

        //private double Guthaben {get; set;}
        public double Guthaben
        {
            get
            {
                double guthaben = 0;
                foreach(var item in alleTransactions)
                {
                    guthaben += item.Amount;
                }
                return guthaben;
            }
            set { }
        }

        private static int Number = 131313;

        private double Ueberziehung = 0; 

        private List<Transaction> alleTransactions = new List<Transaction>();

        public Bankkonto() : this("Ibrahim", 13.0)
        {
            
        }

        public Bankkonto(string name, double guthaben)
        {
            Name = name;
            NeueEinzahlung(guthaben, DateTime.Now, "StartGuthaben");
            //Guthaben = guthaben;
            KontoNummer = Number;
            Number++;

            Ueberziehung -= Guthaben * 0.2;
        }
        public Bankkonto(string name, double guthaben, double minimum)
        {
            Name = name;
            NeueEinzahlung(guthaben, DateTime.Now, "StartGuthaben");
            //Guthaben = guthaben;
            KontoNummer = Number;
            Number++;

            Ueberziehung -= minimum;
        }

        /* public void Abheben(double betrag)
         {
             if ( Ueberziehung < Guthaben - betrag)
             {
                 Guthaben -= betrag;
                 Console.WriteLine("Neues Guthaben beträgt " + Guthaben);
             }
             else
             {
                 Console.WriteLine("Nicht genügend Guthaben vorhanden");
                 Console.WriteLine("Sie haben " + Guthaben + " EURO");
             }

         }
         public void Einzahlen(double betrag)
         {
             Guthaben += betrag;
             Console.WriteLine("Ihr Kontstand beträgt derzeit: " + Guthaben);
         }
        */
        public override string ToString()
        {
            return "Kontonummer " + this.KontoNummer + " Name " + this.Name + " Guthaben " + this.Guthaben + " Überziehungsrahmen " + this.Ueberziehung;
        }
        
        public void UeberzeihungsRahmenErhoehen ()
        {
            Console.WriteLine("Wie hoch soll die Überziehung max sein ? ");
            Ueberziehung = Convert.ToDouble(Console.ReadLine());
        }

        public void NeueEinzahlung (double betrag, DateTime date, string note)
        {
            if(betrag <=0)
            {
                Console.WriteLine("Betrag is zu Niedrig");

            }
            else
            {
                var deposit = new Transaction(betrag, date, note);
                alleTransactions.Add(deposit);
            }
            
        }
        public void NeueAusZahlung (double betrag, DateTime date, string note)
        {
            if(betrag <=0)
            {
                Console.WriteLine("Betrag is zu niedrig. ");
                
            }
            else if (Guthaben - betrag < Ueberziehung)
            {
                Console.WriteLine("Saldo zu gering. Guthaben beträgt " + Guthaben);

            }
            else
            {
                var abhebung = new Transaction(-betrag, date, note);
                alleTransactions.Add(abhebung);
            }

        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            double betrag = 0;

            report.AppendLine("Datum\t\tBetrag\tGuthaben\tNotiz");
            foreach(var item in alleTransactions)
            {
                betrag += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{betrag}\t{item.Notes}");
            }
            return report.ToString();
        }
        public virtual void MonatsEndeTransaction()
        {

        }
    }
}
