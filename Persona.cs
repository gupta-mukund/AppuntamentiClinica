using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppuntamentiClinica
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }

        public Persona(string nome, string cognome, string email, string id)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Id = id;
        }
        public string GetFullName()
        {
            return Nome + " " + Cognome;
        }
    }
}
