using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    abstract class KøretøjType
    {
        public String NummerPlade;
        public DateTime Dato;
        public abstract decimal Pris();

        public abstract string Køretøj();




    }
}
