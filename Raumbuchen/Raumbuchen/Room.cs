using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumbuchen
{
    public class Room
    {
        public int Sitzplaetze { get; set; }
        public bool Belegt { get; set; } 

        public Room(int Anzahl) 
        {
            Belegt = false;
            Sitzplaetze = Anzahl;
        }
    }
}
