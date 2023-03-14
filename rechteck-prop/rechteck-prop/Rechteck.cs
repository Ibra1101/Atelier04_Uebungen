namespace rechteck_prop
{
    public class Rechteck
    {
        private int laenge { get; set; }
        public int breite { get; }

        //Kontruktor

        public Rechteck()
        {
            laenge = 1;
            breite = 1;
        }
      
        private Rechteck(int laenge, int breite)
        {
            this.laenge = laenge;                       //This gehört zum Attributen (oben) und = leange (parameter) 
            this.breite = breite;
        }
        public static Rechteck CreateRechteck(int l, int b)
        {
            return new Rechteck(l, b);
        }

        // SET Methode für breite

        //public void SetBreite(int b) => breite = b; 

        //Set Methode für Laenge
        public void SetLaenge(int l) => laenge = l;

        public int GetLaenge()
        {
            return laenge; 
        }
    }
}