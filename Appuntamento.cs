using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppuntamentiClinica
{
    class Appuntamento
    {
        public DateTime Data { get; set; }
        public Medico Medico { get; set; }
        public Paziente Paziente { get; set; }
    }
}
