using System;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class AgendaCreator : BaseCreator
    {
        private readonly SqlDataReader _dt;
        private readonly string _nome;
        private readonly object[] _objects;

        public AgendaCreator(SqlDataReader dataReader, string alias, params object[] include)
            : base(dataReader, alias, include)
        {
            _dt = dataReader;
            _nome = alias;
            _objects = objects;
        }

        public Agenda Create()
        {
            if (_dt == null)
                return null;

            var agenda = new Agenda
            {

                IdAgenda = _dt.FieldExist(string.Concat(_nome, "IdAgenda")) ? _dt[string.Concat(_nome, "IdAgenda")].DefaultDbNull<int>(0) : 0,
                Data = _dt.FieldExist(string.Concat(_nome, "Data")) ? _dt[string.Concat(_nome, "Data")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                HoraFinal = _dt.FieldExist(string.Concat(_nome, "HoraFinal")) ? _dt[string.Concat(_nome, "HoraFinal")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                HoraInicial = _dt.FieldExist(string.Concat(_nome, "HoraInicial")) ? _dt[string.Concat(_nome, "HoraInicial")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                Complemento = _dt.FieldExist(string.Concat(_nome, "Complemento")) ? _dt[string.Concat(_nome, "Complemento")].DefaultDbNull<string>(null) : string.Empty,
                Situacao = _dt.FieldExist(string.Concat(_nome, "Situacao")) ? EnumUtils<SituacaoAgenda>.FromValue(_dt[string.Concat(_nome, "Situacao")].DefaultDbNull<string>(null)) : SituacaoAgenda.Aberta,

            };

            if (_objects == null) return agenda;

            foreach (var ob in objects)
            {
                if (ob is ClienteCreator)
                    agenda.Cliente = ((ClienteCreator)ob).Create();

                if (ob is ProfissionalCreator)
                    agenda.Profissional = ((ProfissionalCreator)ob).Create();
            }

            return agenda;
        }
    }
}
