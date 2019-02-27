using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class MC : KøretøjType
    {
        

        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public MC(string nummerplade)
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
