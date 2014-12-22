using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;

namespace SGRepositorio.Creator
{
    public class UsuarioCreator : BaseCreator
    {
        private SqlDataReader _dt;
        private string _nome;
        private object[] _objects;

        public UsuarioCreator(SqlDataReader dataReader, string alias, params object[] include)
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

            };

            if (_objects != null)
            {

            }

            return agenda;
        }
    }
}