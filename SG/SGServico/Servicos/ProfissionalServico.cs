using System.Collections.Generic;
using SGEntidades.Entidades;
using SGRepositorio.Repositorio;

namespace SGServico.Servicos
{
    public class ProfissionalServico
    {
        private readonly ProfissionalRepositorio _repositorio = new ProfissionalRepositorio();

        public Profissional Recuperar(Profissional profissional)
        {
            return _repositorio.Recuperar(profissional);
        }

        public List<Profissional> RecuperarLista()
        {
            return _repositorio.RecuperarLista();
        }

        public List<Profissional> RecuperarParticipaAgenda()
        {
            return _repositorio.RecuperarParticipaAgenda();
        }

        public void Inserir(Profissional profissional)
        {
            _repositorio.Inserir(profissional);
        }

        public void Deletar(Profissional profissional)
        {
            _repositorio.Deletar(profissional);
        }

        public void Editar(Profissional profissional)
        {
            _repositorio.Editar(profissional);
        }

        public void DeletarServico(int idProfissional, int idServico)
        {
            _repositorio.DeletarServico(idProfissional, idServico);
        }

        public void InserirServico(int idProfissional, int idServico)
        {
            _repositorio.InserirServico(idProfissional, idServico);
        }



    }
}