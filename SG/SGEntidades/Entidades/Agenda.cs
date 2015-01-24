using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using SGCore.Utils;
using SGEntidades.Enum;

namespace SGEntidades.Entidades
{
    public class Agenda
    {
        public int IdAgenda { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string Complemento { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional Profissional { get; set; }
        public SituacaoAgenda Situacao { get; set; }
        public string SituacaoDescricao => EnumUtils<SituacaoAgenda>.GetDescription(Situacao);
        public List<Servico> Servicos { get; set; }

        public string AgendaDescricao
            => string.Format("{0} - {1}", Cliente.Nome, ListaServicos);

        private string ListaServicos
        {
            get
            {
                var desc = new StringBuilder();
                Servicos.ForEach(x => desc.Append(string.Format("{0}, ", x.Descricao)));
                return Convert.ToString(desc.Remove(desc.Length - 2, 1));
            }
        }

    }
}
