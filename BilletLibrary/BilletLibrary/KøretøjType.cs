using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class KøretøjType
    {
        public String NummerPlade { get; set; }
        public DateTime Dato = new DateTime();
        public abstract decimal Pris();

        public abstract string Køretøj();




    }
}
