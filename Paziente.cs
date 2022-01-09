using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppuntamentiClinica
{
    class Paziente : Persona
    {

        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public Comparto Patologia { get; set; }

        public Paziente(string nome, string cognome, string email, string id, string indirizzo, string codicefiscale) : base(nome, cognome, email, id)
        {
            Indirizzo = indirizzo;
            CodiceFiscale = codicefiscale;
        }
    }
}
