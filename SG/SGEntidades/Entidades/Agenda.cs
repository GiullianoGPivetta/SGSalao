using System;
using SGCore.Utils;
using SGEntidades.Enum;

namespace SGEntidades.Entidades
{
    public class Agenda
    {
        public int? IdAgenda { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public string Complemento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Profissional Profissional { get; set; }
        public SituacaoAgenda Situacao { get; set; }

        public string SituacaoDescricao { get { return EnumUtils<SituacaoAgenda>.GetDescription(Situacao); } }

    }
}
