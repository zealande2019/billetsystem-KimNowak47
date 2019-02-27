using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class Bil : KøretøjType
    {
        

        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public Bil(string nummerplade)
        {
            if (nummerplade.Length < 8)
            {
                this.NummerPlade = nummerplade;
            }
            else
            {
                Exception ex = new Exception("Nummerpladen skal være 7 tegn eller mindre");

                throw ex;
            }
        }
    }
}
