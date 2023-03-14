namespace ArryZahlen
{
    public class Class1
    {
        static int[] zahlen = { 1, 3, 5, 4, 6, 7, 8, 9, 10, 6, 2, 3 };

        public static int ZahlenFolge(int[] zahlen)
        {
            int max = 1;
            int anzahl = 1;

            for(int i=0; i<zahlen.Length-1; i++)
            {
                if (zahlen[i] < zahlen[i+1] )
                {
                    anzahl += 1; 
                }
                else
                {
                    if(max < anzahl)
                    {
                        max = anzahl;

                    }
                    anzahl = 1;
                }
                    
            }

            return max;

        } 

        static void Main(string[] args)
        {
            ZahlenFolge(zahlen);
            Console.WriteLine(ZahlenFolge(zahlen));
            Console.ReadLine();
            
            
        }

    }
}