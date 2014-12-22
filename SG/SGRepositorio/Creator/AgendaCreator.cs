using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class AgendaCreator : BaseCreator
    {
        private SqlDataReader _dt;
        private string _nome;
        private object[] _objects;

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

                IdAgenda = _dt.FieldExist(string.Concat(_nome, "IdAgenda")) ? _dt[string.Concat(_nome, "IdAgenda")].DefaultDbNull<int?>(null) : null,
                Data = _dt.FieldExist(string.Concat(_nome, "Data")) ? _dt[string.Concat(_nome, "Data")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                HoraFim = _dt.FieldExist(string.Concat(_nome, "HoraFim")) ? _dt[string.Concat(_nome, "HoraFim")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                HoraInicio = _dt.FieldExist(string.Concat(_nome, "HoraInicio")) ? _dt[string.Concat(_nome, "HoraInicio")].DefaultDbNull<DateTime>(DateTime.MinValue) : DateTime.MinValue,
                Complemento = _dt.FieldExist(string.Concat(_nome, "Complemento")) ? _dt[string.Concat(_nome, "Complemento")].DefaultDbNull<string>(null) : string.Empty,
                Situacao = _dt.FieldExist(string.Concat(_nome, "Situacao")) ? EnumUtils<SituacaoAgenda>.FromValue(_dt[string.Concat(_nome, "Situacao")].DefaultDbNull<string>(null)) : SituacaoAgenda.Aberta,

            };

            if (_objects != null)
            {
                foreach (var ob in objects)
                {
                    if (ob is ClienteCreator)
                        agenda.Cliente = ((ClienteCreator)ob).Create();

                    if (ob is ProfissionalCreator)
                        agenda.Profissional = ((ProfissionalCreator)ob).Create();
                }
            }

            return agenda;
        }
    }
}
