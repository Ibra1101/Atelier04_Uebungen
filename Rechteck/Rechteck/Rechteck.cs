using System;

namespace rechteck // Note: actual namespace depends on the project name.
{
    internal class Rechteck
    {
        int laenge = 0;
        int breite = 0;


        //Konstruktor

        public Rechteck()
        {
            laenge = 1;
            breite = 1;
        }
        //Konstruktor2 -Werte 
        public Rechteck (int l, int b)
        {
            laenge= l;
            breite= b;
        }
        public void SetLaenge(int l)
        {
            laenge = l;
        }
        public void SetBreite(int b)
        {
            breite = b;
        }

        //get Methode
        public int GetLaenge()
        {
            return laenge;
        }
        public int Getbreite()
        {
            return breite;
        }
        public int Umfang()
        {
            return 2*(laenge+breite);
        }
    }
}