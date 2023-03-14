using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roemische_Zahlen
{
    public class Umwandeln
    {
        public static string Regeln(int zahl)
        {
            string rueckgabe = "";
            int zahl1 = zahl;
            do
            {
                if (zahl >= 1000)
                {

                    rueckgabe += "M";
                    zahl -= 1000;

                }
                else if (zahl >= 900)
                {

                    rueckgabe += "CM";
                    zahl -= 900;

                }
                else if (zahl >= 500)
                {

                    rueckgabe += "D";
                    zahl -= 500;

                }
                else if (zahl >= 400)
                {
                    rueckgabe += "CD";
                    zahl -= 400;
                }
                else if (zahl >= 100)
                {

                    rueckgabe += "C";
                    zahl -= 100;
                }
                else if (zahl >= 90)
                {

                    rueckgabe += "XC";
                    zahl -= 90;
                }
                else if (zahl >= 50)
                {


                    rueckgabe += "L";
                    zahl -= 50;

                }
                else if (zahl >= 40)
                {

                    rueckgabe += "XL";
                    zahl -= 40;
                }
                else if (zahl >= 10)
                {
                    rueckgabe += "X";
                    zahl -= 10;
                }
                else if (zahl >= 9)
                {

                    rueckgabe += "IX";
                    zahl -= 9;

                }
                else if (zahl >= 5)
                {
                    rueckgabe += "V";
                    zahl -= 5;
                }
                else if (zahl >= 4)
                {
                    rueckgabe += "IV";
                    zahl -= 4;

                }
                else if (zahl >= 1)
                {
                    rueckgabe += "I";
                    zahl -= 1;
                }
            } while (zahl >= 1);
            return rueckgabe;
        }

        public static int RomentoNormal(string romenZahl)
        {
            int romenToNormal = 0;
            /*List<char> ranking = new List<char>()
            { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };*/
            List<char> roemischezahl = new List<char>(romenZahl);
            for (int i = 0; i < roemischezahl.Count; i++)
            {
                if (i + 1 < roemischezahl.Count  && romenZahl[i + 1 ] == 'M' && romenZahl[i] == 'C' )
                {
                    romenToNormal -= 100;
                }
              
                else if (romenZahl[i] == 'M')
                {
                    romenToNormal += 1000;
                }
                else if (i + 1 < roemischezahl.Count && romenZahl[i + 1] == 'D' && romenZahl[i] == 'C')
                {
                    romenToNormal -= 50;
                }
                else if (romenZahl[i] == 'D')
                {
                    romenToNormal += 500;
                }
                else if (i + 1 < roemischezahl.Count && romenZahl[i + 1] == 'C' && romenZahl[i] == 'X')
                {
                    romenToNormal -= 50;
                }

                else if (romenZahl[i] == 'C')
                {
                    romenToNormal += 100;
                }
                else if (i + 1 < roemischezahl.Count && romenZahl[i + 1] == 'L' && romenZahl[i] == 'X')
                {
                    romenToNormal -= 10;
                }
                else if (romenZahl[i] == 'L')
                {
                    romenToNormal += 50;
                }
                else if (romenZahl[i] == 'X')  
                {
                    romenToNormal += 10;
                }
                else if (i + 1 < roemischezahl.Count && romenZahl[i + 1] == 'X' && romenZahl[i] == 'I')
                {
                    romenToNormal -= 1;
                }
                else if (i + 1 < roemischezahl.Count && romenZahl[i + 1] == 'V' && romenZahl[i] == 'I')
                {
                    romenToNormal -= 1;
                }
                else if (romenZahl[i] == 'V')
                {
                    romenToNormal += 5;
                }
                else if (romenZahl[i] == 'I')
                {
                    romenToNormal += 1;
                }


            }
            return romenToNormal; 
        }
    }
}
