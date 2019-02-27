using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class Bil : KøretøjType
    {
        public String NummerPlade; 
        public DateTime Dato;

        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }


    }
}
