using System;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class ProfissionalCreator : BaseCreator
    {
        private readonly SqlDataReader _dt;
        private readonly string _nome;
        private readonly object[] _objects;

        public ProfissionalCreator(SqlDataReader dataReader, string alias, params object[] include)
            : base(dataReader, alias, include)
        {
            _dt = dataReader;
            _nome = alias;
            _objects = objects;
        }

        public Profissional Create()
        {
            if (_dt == null)
                return null;

            var profissional = new Profissional
            {
                IdProfissional = _dt.FieldExist(string.Concat(_nome, "IdProfissional")) ? _dt[string.Concat(_nome, "IdProfissional")].DefaultDbNull<int>(0) : 0,
                Endereco = _dt.FieldExist(string.Concat(_nome, "Endereco")) ? _dt[string.Concat(_nome, "Endereco")].DefaultDbNull<string>(null) : string.Empty,
                Bairro = _dt.FieldExist(string.Concat(_nome, "Bairro")) ? _dt[string.Concat(_nome, "Bairro")].DefaultDbNull<string>(null) : string.Empty,
                Celular = _dt.FieldExist(string.Concat(_nome, "Celular")) ? _dt[string.Concat(_nome, "Celular")].DefaultDbNull<string>(null) : string.Empty,
                Cidade = _dt.FieldExist(string.Concat(_nome, "Cidade")) ? _dt[string.Concat(_nome, "Cidade")].DefaultDbNull<string>(null) : string.Empty,
                Nome = _dt.FieldExist(string.Concat(_nome, "Nome")) ? _dt[string.Concat(_nome, "Nome")].DefaultDbNull<string>(null) : string.Empty,
                Numero = _dt.FieldExist(string.Concat(_nome, "Numero")) ? _dt[string.Concat(_nome, "Numero")].DefaultDbNull<string>(null) : string.Empty,
                Telefone = _dt.FieldExist(string.Concat(_nome, "Telefone")) ? _dt[string.Concat(_nome, "Telefone")].DefaultDbNull<string>(null) : string.Empty,
                Email = _dt.FieldExist(string.Concat(_nome, "Email")) ? _dt[string.Concat(_nome, "Email")].DefaultDbNull<string>(null) : string.Empty,
                Nascimento = _dt.FieldExist(string.Concat(_nome, "Nascimento")) ? _dt[string.Concat(_nome, "Nascimento")].DefaultDbNull<DateTime?>(null) : null,
                ParticipaAgenda = _dt.FieldExist(string.Concat(_nome, "ParticipaAgenda")) ? EnumUtils<SimNao>.FromValue(_dt[string.Concat(_nome, "ParticipaAgenda")].DefaultDbNull<string>(null)) : SimNao.Nao,
                Status = _dt.FieldExist(string.Concat(_nome, "Status")) ? EnumUtils<Status>.FromValue(_dt[string.Concat(_nome, "Status")].DefaultDbNull<string>(null)) : Status.NaoInformado,
            };

            if (_objects != null)
            {

            }

            return profissional;
        }
    }
}
