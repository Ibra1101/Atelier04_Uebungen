using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] deineLottozahlen = new int[6];
            int[] lottoZahlen = new int[6];


            Random zufallsZahl = new Random();

            
            for(int i= 0; i<=5;i++)
            {
                int j = 0;
                Console.WriteLine("Deine Lotto Zahlen sind ");
                deineLottozahlen[i]= int.Parse(Console.ReadLine());
                if (deineLottozahlen[i] >=46 || deineLottozahlen[i] < 1)
                {
                    Console.WriteLine("Bitte gültige Zahl eingeben (1-45)");
                    deineLottozahlen[i] = int.Parse(Console.ReadLine());
                }
                foreach(int y in deineLottozahlen)
                {
                    if(i>0 && j<i && deineLottozahlen[i] ==y)
                    {
                        Console.WriteLine("Bitte eine andere Zahl hinschreiben");
                        i--; 
                    }j++;
                }             
            }

            for (int i = 0; i <=5; i++)
            {
                lottoZahlen[i] = zufallsZahl.Next(1, 45 + 1);
                Console.WriteLine("Lotto zahlen "+lottoZahlen[i]+" ");
                int j = 0;
                foreach(int y in lottoZahlen)
                {
                    
                    if (i>0 && j<i && lottoZahlen[i] == y )
                    {
                        
                        i--;
                    }j++;
                }
            }
            Array.Sort(lottoZahlen);
            Array.Sort(deineLottozahlen);
            int treffer = 0;
            foreach(int y in lottoZahlen)
            {
                foreach(int i in deineLottozahlen)
                {
                    if(y == i)
                    {

                        treffer++;
                    }
                }
            }
            Console.WriteLine("Du hast " + treffer + " getroffen");
        }
    }
}