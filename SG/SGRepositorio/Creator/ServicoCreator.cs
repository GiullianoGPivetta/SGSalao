using System;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class ServicoCreator : BaseCreator
    {
        private readonly SqlDataReader _dt;
        private readonly string _nome;
        private readonly object[] _objects;

        public ServicoCreator(SqlDataReader dataReader, string alias, params object[] include)
            : base(dataReader, alias, include)
        {
            _dt = dataReader;
            _nome = alias;
            _objects = objects;
        }

        public Servico Create()
        {
            if (_dt == null)
                return null;

            var servico = new Servico
            {
                IdServico = _dt.FieldExist(string.Concat(_nome, "IdServico")) ? _dt[string.Concat(_nome, "IdServico")].DefaultDbNull<int>(0) : 0,
                Descricao = _dt.FieldExist(string.Concat(_nome, "Descricao")) ? _dt[string.Concat(_nome, "Descricao")].DefaultDbNull<string>(null) : string.Empty,
                Tempo = _dt.FieldExist(string.Concat(_nome, "Tempo")) ? _dt[string.Concat(_nome, "Tempo")].DefaultDbNull<int>(0) : 0,
                Valor = _dt.FieldExist(string.Concat(_nome, "Valor")) ? _dt[string.Concat(_nome, "Valor")].DefaultDbNull<int>(0) : 0,
                Status = _dt.FieldExist(string.Concat(_nome, "Status")) ? EnumUtils<Status>.FromValue(_dt[string.Concat(_nome, "Status")].DefaultDbNull<string>(string.Empty)) : Status.NaoInformado,
            };

            if (_objects != null)
            {

            }

            return servico;
        }

    }
}