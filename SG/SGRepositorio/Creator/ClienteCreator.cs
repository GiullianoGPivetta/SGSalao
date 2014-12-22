using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class ClienteCreator : BaseCreator
    {
        private SqlDataReader _dt;
        private string _nome;
        private object[] _objects;

        public ClienteCreator(SqlDataReader dataReader, string alias, params object[] include)
            : base(dataReader, alias, include)
        {
            _dt = dataReader;
            _nome = alias;
            _objects = objects;
        }

        public Cliente Create()
        {
            if (_dt == null)
                return null;

            var cliente = new Cliente
            {
                IdCliente = _dt.FieldExist(string.Concat(_nome, "IdCliente")) ? _dt[string.Concat(_nome, "IdCliente")].DefaultDbNull<int?>(null) : null,
                Endereco = _dt.FieldExist(string.Concat(_nome, "Endereco")) ? _dt[string.Concat(_nome, "Endereco")].DefaultDbNull<string>(null) : string.Empty,
                Bairro = _dt.FieldExist(string.Concat(_nome, "Bairro")) ? _dt[string.Concat(_nome, "Bairro")].DefaultDbNull<string>(null) : string.Empty,
                Celular = _dt.FieldExist(string.Concat(_nome, "Celular")) ? _dt[string.Concat(_nome, "Celular")].DefaultDbNull<string>(null) : string.Empty,
                Cidade = _dt.FieldExist(string.Concat(_nome, "Cidade")) ? _dt[string.Concat(_nome, "Cidade")].DefaultDbNull<string>(null) : string.Empty,
                Nome = _dt.FieldExist(string.Concat(_nome, "Nome")) ? _dt[string.Concat(_nome, "Nome")].DefaultDbNull<string>(null) : string.Empty,
                Numero = _dt.FieldExist(string.Concat(_nome, "Numero")) ? _dt[string.Concat(_nome, "Numero")].DefaultDbNull<string>(null) : string.Empty,
                Telefone = _dt.FieldExist(string.Concat(_nome, "Telefone")) ? _dt[string.Concat(_nome, "Telefone")].DefaultDbNull<string>(null) : string.Empty,
                Email = _dt.FieldExist(string.Concat(_nome, "Email")) ? _dt[string.Concat(_nome, "Email")].DefaultDbNull<string>(null) : string.Empty,
                Nascimento = _dt.FieldExist(string.Concat(_nome, "Nascimento")) ? _dt[string.Concat(_nome, "Nascimento")].DefaultDbNull<DateTime?>(null) : null,
                CPF = _dt.FieldExist(string.Concat(_nome, "CPF")) ? _dt[string.Concat(_nome, "CPF")].DefaultDbNull<string>(null) : string.Empty,
                Status = _dt.FieldExist(string.Concat(_nome, "Status")) ? EnumUtils<Status>.FromValue(_dt[string.Concat(_nome, "Status")].DefaultDbNull<string>(null)) : Status.NaoInformado,
            };

            if (_objects != null)
            {

            }

            return cliente;
        }
    }
}