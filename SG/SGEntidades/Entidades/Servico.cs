using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEntidades.Enum;

namespace SGEntidades.Entidades
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Tempo { get; set; }
        public Status Status { get; set; }
        public bool Selecionado { get; set; }
    }
}
