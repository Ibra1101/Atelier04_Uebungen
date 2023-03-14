namespace rechteck_prop
{
    public class Rechteck
    {
        public int laenge { get; set; }
        public int breite { get; set; }

        //Kontruktor

        public Rechteck() 
        {
            laenge = 1;
            breite = 1;
        }  
        public Rechteck(int l, int b)
        {
            laenge = l;
            breite = b;
        }
    }
}