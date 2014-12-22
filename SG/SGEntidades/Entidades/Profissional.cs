using System;
using System.Collections.Generic;
using System.Security.Permissions;
using SGEntidades.Enum;

namespace SGEntidades.Entidades
{
    public class Profissional
    {
        public int? IdProfissional { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Email { get; set; }
        public SimNao ParticipaAgenda { get; set; }
        public Status Status { get; set; }
    }
}
