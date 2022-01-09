using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppuntamentiClinica
{
    class Medico : Persona
    {
        public Comparto Specializzazione { get; set; }

        public Medico(string nome, string cognome, string email, string id) : base (nome, cognome, email, id)
        {
        
        }
    }
}
