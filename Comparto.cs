using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppuntamentiClinica
{
    class Comparto
    {
        //public Comparto(string id, string nome, Comparto soluzione)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Soluzione = soluzione;
        //}

        public string Id { get; set; }
        public string Nome { get; set; }
        public List<Comparto> Soluzione { get; set; }
        public Comparto()
        {
            Soluzione = new List<Comparto>();
        }
    }
}
