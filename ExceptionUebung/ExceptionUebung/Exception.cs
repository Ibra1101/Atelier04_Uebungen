using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionUebung
{
    public class Exceptions : Exception
    {
        public Exceptions(string msg): base(msg) 
        
        { 
        }
    }
}
