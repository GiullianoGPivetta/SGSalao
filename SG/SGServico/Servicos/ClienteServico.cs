using System.Collections.Generic;
using SGEntidades.Entidades;
using SGRepositorio.Repositorio;

namespace SGServico.Servicos
{
    public class ClienteServico
    {
        private readonly ClienteRepositorio _repositorio = new ClienteRepositorio();

        public Cliente Recuperar(Cliente cliente)
        {
            return _repositorio.Recuperar(cliente);
        }

        public List<Cliente> RecuperarLista()
        {
            return _repositorio.RecuperarLista();
        }

        public void Inserir(Cliente cliente)
        {
            _repositorio.Inserir(cliente);
        }

        public void Deletar(Cliente cliente)
        {
            _repositorio.Deletar(cliente);
        }

        public void Editar(Cliente cliente)
        {
            _repositorio.Editar(cliente);
        }
    }
}