using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> deineLottozahlen = new List<int>();
            List<int> lottoZahlen = new List<int>(); ;


            Random zufallsZahl = new Random();


            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Deine Lotto Zahlen sind ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 46 || x < 1)
                {
                    Console.WriteLine("Bitte gültige Zahl eingeben (1-45)");
                    i--;

                }
                else if (deineLottozahlen.Contains(x))
                {
                    Console.WriteLine("Doppelte Zahl");
                    i--;
                }
                else
                {
                    deineLottozahlen.Add(x);
                }
            }

            for (int i = 0; i <= 5; i++)
            {
                lottoZahlen.Add(zufallsZahl.Next(1, 45 + 1));
                Console.WriteLine("Lotto zahlen " + lottoZahlen[i] + " ");
                int j = 0;
                foreach (int y in lottoZahlen)
                {

                    if (i > 0 && j < i && lottoZahlen[i] == y)
                    {

                        i--;
                    }
                    j++;
                }
            }
            lottoZahlen.Sort();
            deineLottozahlen.Sort();
            int treffer = 0;
            foreach (int y in lottoZahlen)
            {
                if(deineLottozahlen.Contains(y))
                {
                    treffer++;
                }
            }
            Console.WriteLine("Du hast " + treffer + " getroffen");
        }
    }
}