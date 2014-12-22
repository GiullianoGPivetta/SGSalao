using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using SGEntidades.Entidades;

namespace SGRepositorio.Creator
{
    public class UFCreator : BaseCreator
    {
        private SqlDataReader _dt;
        private string _nome;
        private object[] _objects;

        public UFCreator(SqlDataReader dataReader, string alias, params object[] include)
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
