using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionUebung
{
    public class Dividieren
    {
        public static int ZahlenDividieren(int dividend,int divisor ) 
        {
            int quotient = 0;
            try
            {
                
                if (divisor == 0)
                {
                    quotient = 0;
                    throw new Exceptions(" Division durch null nicht möglich " + quotient);
                }
                quotient = dividend / divisor;
            }
            catch(Exceptions e )
            {
                Console.WriteLine(e);
            } 
          
            return quotient;
        }
            
    }
}
