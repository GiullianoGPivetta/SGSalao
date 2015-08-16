using System;
using System.Collections.Generic;
using SGEntidades.Entidades;
using SGRepositorio.Repositorio;

namespace SGServico.Servicos
{
    public class AgendaServico
    {
        private readonly AgendaRepositorio _repositorio = new AgendaRepositorio();

        public Agenda Recuperar(Agenda agenda)
        {
            return _repositorio.Recuperar(agenda);
        }

        public List<Agenda> RecuperarLista(DateTime data)
        {
            return _repositorio.RecuperarLista(data);
        }

        public void Inserir(Agenda agenda)
        {
            _repositorio.Inserir(agenda);
        }

        public void Deletar(Agenda agenda)
        {
            _repositorio.Deletar(agenda);
        }

        public void Editar(Agenda agenda)
        {
            _repositorio.Editar(agenda);
        }

        public void GravarAgendaOcorrencia(AgendaOcorrencia ocorrencia)
        {
            _repositorio.GravarAgendaOcorrencia(ocorrencia);
        }

        public List<AgendaOcorrencia> RecuperarListaOcorrencia(DateTime data)
        {
            return _repositorio.ListaOcorrencia(data);
        }
    }
}