using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumbuchen
{
    public class Company
    {
        public string Name { get; private set; }
        public int AnzahlDerRaeume { get; private set; }

        public string Adresse { get; private set; }

        public int MaxAnzahlDerRaeume { get; private set; }


        private int Freie_Raeume = 0;

        List<Room> Raumliste = new List<Room>();
        public Company(string name, int anzahlDerRaueme, string adresse, int maxAnzahlDerRaeume) 
        { 
            Name = name;
            Adresse = adresse;

            if (anzahlDerRaueme > maxAnzahlDerRaeume)
            {
                AnzahlDerRaeume = maxAnzahlDerRaeume;
                MaxAnzahlDerRaeume = maxAnzahlDerRaeume;
            }
            else
            {
                AnzahlDerRaeume = anzahlDerRaueme;
                MaxAnzahlDerRaeume = maxAnzahlDerRaeume;
            }

            for(int i = 0; i < maxAnzahlDerRaeume; i++) 
            {
                Room a = new Room(30);

                if (i >= AnzahlDerRaeume)
                {
                    a.Belegt = true;
                }

                Raumliste.Add(a);




            }

        }
        public int SucheRaum(int sitzplazt)
        {
            int i = 0;
            int index = -1;
            int anzahl_plaetze = 0;
            Room b = null;

            foreach (Room a in Raumliste)
            {
                if (a.Sitzplaetze >= sitzplazt && a.Belegt == false)
                {
                    if (index == -1)
                    {
                        index = i;
                        anzahl_plaetze = a.Sitzplaetze;
                        b = a;
                    }
                    else
                    {
                        if(anzahl_plaetze > a.Sitzplaetze)
                        {
                            index = i;
                            anzahl_plaetze = a.Sitzplaetze;
                            b = a;
                        }
                    }
                }
                i++; 
            }
            if(index != -1)
            {
                Raumliste[index].Belegt = true;
            }
            Console.WriteLine("Raum hat" + b.Sitzplaetze);
            Console.WriteLine(index);
            return index;

        }

        public int Frei()
        {
            Freie_Raeume = 0;
            foreach(Room platz in Raumliste)
            {
                if(platz.Belegt == false)
                {
                    Freie_Raeume += 1;
                }
            }
            return Freie_Raeume;

        }
        public void FuegeEinenRaumHinzu(int menge)
        {
            Room neuerRaum = new Room(menge);
            Raumliste.Add(neuerRaum);
            Console.WriteLine("neuer Raum angelegt");

        }

    }
}
