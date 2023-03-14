using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionUebung
{
    public class Fakultaet
    {
        public static int Fakultaetrechnen(int fak)
        {
            int erg = 1;
            for(int i = 1; i <= fak; i++) 
            {
               erg *= i;
       
            }
            return erg;
        }
    }
}
