using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffeversenken
{
    public class Gebiet
    {
        private bool FeldWurdeBeschossen;
        private bool SchiffIstAufmFeld;

        public Gebiet()
        {
            FeldWurdeBeschossen = false;
            SchiffIstAufmFeld = false;
        }
        public bool BeschiesseFeld()
        {
            FeldWurdeBeschossen = true;
            if(SchiffIstAufmFeld)
            {
                VersenkeSchiff();
                return true;    
            }
            else
            {
                return false;
            }
        }
        public void VersenkeSchiff()
        {
            SchiffIstAufmFeld = false;
        }
        public void SetzeSchiffe()
        {
            SchiffIstAufmFeld = true;
        }
        public bool IstDasSchiffAufmFeld()
        {
             return SchiffIstAufmFeld;
            
        }
        public bool FeldWurdebeschossen()
        {
            return FeldWurdeBeschossen;
        }
    }
}
