using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rennschnecke1
{
    class Rennschnecke
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string rasse;
        public string Rasse
        {
            get { return rasse; }
            set { rasse = value; }
        }
        int maxGeschwindigkeit;
        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
            set { maxGeschwindigkeit = value; }
        }

        public double ZurueckGelegterWeg { get; set; }

        public Rennschnecke()
        {
            Name = "Standart";
            Rasse = "Nackt";
            MaxGeschwindigkeit = 5;
            ZurueckGelegterWeg = 0;
        }
        public Rennschnecke(string name, int maxgeschwindigkeit)
        {
            this.name = name;
            this.maxGeschwindigkeit= maxgeschwindigkeit;
            Rasse = "Standart";
            ZurueckGelegterWeg = 0;
        }

        public Rennschnecke(string name, string rasse, int maxgeschwindigkeit, int zurueckGelegterWeg) { }

        public void Krieche()
        {
            var rand = new Random();

            int geschwindigkeit = rand.Next(1,MaxGeschwindigkeit);

            ZurueckGelegterWeg += geschwindigkeit;

        }

        public override string ToString()
        {
            return "Name: " + Name + " Rasse: " + Rasse + " Max Geschwindigkeit " + MaxGeschwindigkeit + " Zurückgelegter Weg " + ZurueckGelegterWeg;
        }

    }
}
