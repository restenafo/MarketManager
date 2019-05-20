using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketManager
{
    public class Dipendente
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public int permessi { get; set; }
        public string matricola { get; set; }
        public bool abilitato { get; set; }
        public string codiceFiscale { get; set; }
        public string dataNascita { get; set; }
        public string luogoNascita { get; set; }
        public string nazionalita { get; set; }
    }
}