using System;
using System.Collections.Generic;
using System.Text;

namespace Zjazd9_uzupelnienie
{
    internal class Reklama
    {
        public GrupaWiekowa grupaWiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst,GrupaWiekowa grupaWiekowa, Zainteresowania zainteresowania)
        {
            this.grupaWiekowa = grupaWiekowa;
            this.zainteresowania = zainteresowania;
            Tekst = tekst;
        }

        public string Tekst { get; set; }

  
    
    }
}
