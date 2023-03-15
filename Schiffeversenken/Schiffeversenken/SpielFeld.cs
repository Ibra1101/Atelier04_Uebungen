using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffeversenken
{
    public class SpielFeld 
    {
        private Gebiet[,] Feld;

        public SpielFeld()
        {
            Feld = new Gebiet[10, 10];
            //Anfangswerte setzen
            for(int y = 0; y < 10; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    Feld[x, y] = new Gebiet();
                }
            }

        }

        //Methoden
        public string schiesse(int x, int y)
        {
             Feld[x,y].BeschiesseFeld();
            if(Feld[x, y].BeschiesseFeld() == true)
            {
                return "treffer";
            }
            else
            {
                return "daneben";
            }
            
        }
        public void GibSpielfeldAufDieKonsoleAus()
        {
            Console.WriteLine("\n \t0 \t1 \t2 \t3 \t4 \t6 \t7 \t8 \t9 \t10");
            for (int x= 0; x < 10; x++)
            {
                for(int y= 0; y < 10; y++)
                {
                    
                    if(Feld[x, y].IstDasSchiffAufmFeld() == true )
                    {
                        Console.Write("\tX");
                    }
                    else if (Feld[x, y].FeldWurdebeschossen() == true)
                    {
                        Console.Write("\t*");
                    }
                    else if (Feld[x, y].IstDasSchiffAufmFeld() == false)
                    {
                        Console.Write("\t-");
                    }
                   
                        
                }
                Console.WriteLine("");
            }
            

        }
        public void SetzeWagrechtesSchiff(int laenge, int x, int y)
        {
            try
            {
                if(x <10 && y < 10 && y + laenge < 10)
                {
                    for (int i = 0; i < laenge; i++)
                    {
                        Feld[x, y + i].SetzeSchiffe();
                    }
                }
                else
                {
                    throw new Exception("Bist außerhalb des Spielfedes");
                }
                

            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void SetzeSenkrechtesSchiff(int breite, int x, int y ) 
        {
            try
            {
                if (x < 10 && y < 10 && x + breite < 10)
                {
                    for (int i = 0; i < breite; i++)
                    {
                        Feld[x + i, y].SetzeSchiffe();
                    }
                }
                else
                {
                    throw new Exception("Bist außerhalb des Spielfedes");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public Boolean PruefeObGewonnen()
        {
            for(int y = 0;y < 10; y++)
            {
                for(int x = 0;x < 10; x++)
                {
                    if (Feld[x,y].IstDasSchiffAufmFeld() == true)
                    {
                        Console.WriteLine("Spiel geht weiter");
                        return false;
                    }
                }
            }
            Console.WriteLine("Spiel Gewonnen! ");
            return true;
        }
    }
}
