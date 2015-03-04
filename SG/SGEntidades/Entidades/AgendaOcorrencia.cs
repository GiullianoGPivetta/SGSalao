using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEntidades.Entidades
{
    public class AgendaOcorrencia
    {
        public int IdOcorrencia { get; set; }
        public Agenda Agenda { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHora { get; set; }

    }
}
