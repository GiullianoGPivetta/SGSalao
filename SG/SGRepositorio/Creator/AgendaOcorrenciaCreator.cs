using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    internal class AgendaOcorrenciaCreator : BaseCreator
    {
        private readonly SqlDataReader _dt;
        private readonly string _nome;
        private readonly object[] _objects;

        public AgendaOcorrenciaCreator(SqlDataReader dataReader, string alias, params object[] include)
            : base(dataReader, alias, include)
        {
            _dt = dataReader;
            _nome = alias;
            _objects = objects;
        }

        public AgendaOcorrencia Create()
        {
            if (_dt == null)
                return null;

            var agenda = new AgendaOcorrencia
            {

                IdOcorrencia = 
                    _dt.FieldExist(string.Concat(_nome, "IdOcorrencia"))
                        ? _dt[string.Concat(_nome, "IdOcorrencia")].DefaultDbNull<int>(0)
                        : 0,
                DataHora = 
                    _dt.FieldExist(string.Concat(_nome, "DataHora"))
                        ? _dt[string.Concat(_nome, "DataHora")].DefaultDbNull<DateTime>(DateTime.MinValue)
                        : DateTime.MinValue,
              
                Motivo = 
                    _dt.FieldExist(string.Concat(_nome, "Motivo"))
                        ? _dt[string.Concat(_nome, "Motivo")].DefaultDbNull<string>(null)
                        : string.Empty,
            };

            if (_objects == null) return agenda;

            foreach (var ob in objects)
            {
                if (ob is AgendaCreator)
                    agenda.Agenda = ((AgendaCreator) ob).Create();
            }

            return agenda;
        }
    }
}
