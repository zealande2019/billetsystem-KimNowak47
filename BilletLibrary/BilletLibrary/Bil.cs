using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : KøretøjType
    {

        private decimal NormalPris { get; set; } = 125;

        public override decimal Pris()
        {
            return NormalPris;
        }

        public override string Køretøj()
        {
            return "Bil";
        }

       

        public Bil()
        {

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
