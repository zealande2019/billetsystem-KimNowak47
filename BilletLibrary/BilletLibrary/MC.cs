using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : KøretøjType
    {
        private decimal NormalPris = 125; 

        public override decimal Pris()
        {
            return NormalPris;
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public MC()
        { }
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

        public MC(string nummerplade, string brobizz )
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

            if (brobizz.Equals("brobizz"))
            {
                NormalPris = 118;
            }
        }

    }
}
