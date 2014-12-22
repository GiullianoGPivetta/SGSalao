using System;
using System.Collections.Generic;
using SGCore.Utils;
using SGEntidades.Enum;

namespace SGEntidades.Entidades
{
    public class Cliente
    {
        public int? IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string CPF { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Email { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Status Status { get; set; }

        public string StatusDescricao { get { return EnumUtils<Status>.GetDescription(Status); } }


    }
}
